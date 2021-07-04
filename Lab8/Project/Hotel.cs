// Licensed to the Mezidia Foundation under one or more agreements.
// The Mezidia Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using Hotel.Project;

namespace Hotel
{
    /// <summary>
    /// Hotel class, where We have all methods and
    /// fields for hotels
    /// </summary>
    /// <seealso cref="Hotel.Project.IOrder" />
    /// <seealso cref="Hotel.Project.IRoom" />
    public class Hotel : IOrder, IRoom
    {
        /// <summary>
        /// Delegate for replacing Console.WriteLine
        /// </summary>
        /// <param name="text">The text.</param>
        delegate void Message(string text);

        /// <summary>
        /// Our interpretation of Console.WriteLine
        /// </summary>
        /// <param name="text">The text.</param>
        private static void ShowMessage(string text)
        {
            Console.WriteLine(text);
        }

        /// <summary>
        /// The dialog for Console.Write'ing
        /// </summary>
        private readonly Message _dlg = ShowMessage;

        /// <summary>
        /// The number of stars
        /// </summary>
        private int _numberOfStars;

        /// <summary>
        /// We need this to get and set numberOfStars.
        /// Also We check if value isn't null.
        /// </summary>
        public int NumberOfStars
        {
            get
            {
                return _numberOfStars;
            }
            set
            {
                if (value.ToString() != null && value >= 1 && value <= 5)
                {
                    _numberOfStars = value;
                }
                else
                {
                    _dlg("Введiть правильну кiлькiсть зiрок");
                }
            }
        }

        /// <summary>
        /// The description
        /// </summary>
        private string _description;

        /// <summary>
        /// We need this to get and set description.
        /// Also We check if value > 20.
        /// </summary>
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (value.Length > 20)
                {
                    _description = value;
                }
                else
                {
                    _dlg("Введiть бiльшу кiлькiсть символiв");
                }
            }
        }

        /// <summary>
        /// The rating
        /// </summary>
        private int _rating;

        /// <summary>
        /// We need this to get and set rating.
        /// Also We check if value isn't null.
        /// </summary>
        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value.ToString() != null)
                {
                    _rating = value;
                }
                else
                {
                    _dlg("Введiть не пустий iдентифiкатор рейтингу");
                }
            }
        }

        /// <summary>
        /// The hotel identifier
        /// </summary>
        private int _hotelID;

        /// <summary>
        /// We need this to get and set hotelID.
        /// Also We check if value isn't null.
        /// </summary>
        public int HotelID
        {
            get
            {
                return _hotelID;
            }
            set
            {
                if (value.ToString() != null)
                {
                    _hotelID = value;
                }
                else
                {
                    _dlg("Введiть не пустий iдентифiкатор готелю");
                }
            }
        }

        /// <summary>
        /// The hotel name
        /// </summary>
        private string _hotelName;

        /// <summary>
        /// We need this to get and set hotelName.
        /// Also We check if value < 15.
        /// </summary>
        public string HotelName
        {
            get
            {
                return _hotelName;
            }
            set
            {
                if (value.Length < 15)
                {
                    _hotelName = value;
                }
                else
                {
                    _dlg("Забагато символiв для iменi готелю");
                }
            }
        }

        /// <summary>
        /// The address
        /// </summary>
        private string _address;

        /// <summary>
        /// We need this to get and set hotelName.
        /// Also We check if value < 15.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (value.Length > 1)
                {
                    _address = value;
                }
                else
                {
                    _dlg("Невiрна адреса");
                }
            }
        }

        /// <summary>
        /// Implements the operator !.
        /// </summary>
        /// <param name="hotel">The hotel.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator !(Hotel hotel)
        {
            return hotel.Rating <= 0;
        }

        /// <summary>
        /// Implements the operator true.
        /// </summary>
        /// <param name="hotel">The hotel.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator true(Hotel hotel)
        {
            return hotel.Rating > 0;
        }

        /// <summary>
        /// Implements the operator false.
        /// </summary>
        /// <param name="hotel">The hotel.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator false(Hotel hotel)
        {
            return hotel.Rating <= 0;
        }

        public City City { get; set; }
        public List<Room> Rooms = new List<Room>();
        public List<ConcreteOrder> Orders = new List<ConcreteOrder>();

        public delegate void HotelHandler(string messageString);
        public event HotelHandler EventForNotifying;

        /// <summary>
        /// Initializes a new instance of the <see cref="Hotel"/> class.
        /// </summary>
        /// <param name="hotelID">The hotel identifier.</param>
        /// <param name="hotelName">Name of the hotel.</param>
        /// <param name="address">The address.</param>
        /// <param name="description">The description.</param>
        public Hotel(int hotelID, string hotelName,
            string address, string description)
        {
            HotelID = hotelID;
            HotelName = hotelName;
            Address = address;
            Description = description;

            // Temp for Composition
            Room FirstRoom = new Room(1, 1, "First", 2,
                this, true, "Big", 5, true);
            Rooms.Add(FirstRoom);

            _dlg($"Готель {hotelName} створено");
        }

        /// <summary>
        /// Creates the room.
        /// </summary>
        /// <param name="roomID">The room identifier.</param>
        /// <param name="roomNumber">The room number.</param>
        /// <param name="roomName">Name of the room.</param>
        /// <param name="roomSize">Size of the room.</param>
        /// <param name="hotel">The hotel.</param>
        /// <param name="tv">The tv.</param>
        /// <param name="roomType">Type of the room.</param>
        /// <param name="numberOfBeds">The number of beds.</param>
        /// <param name="balcony">The balcony.</param>
        public void CreateRoom(int roomID, int roomNumber,
            string roomName, int roomSize, Hotel hotel, bool? tv,
            string roomType, int numberOfBeds, bool? balcony)
        {
            Room room = new Room(roomID, roomNumber, roomName,
                roomSize, hotel, tv, roomType, numberOfBeds, balcony);
            Rooms.Add(room);

            EventForNotifying?.Invoke($"Додано кiмнату номер {room.RoomNumber} готелю " +
                $"{room.Hotel.HotelName} вiд подiї");
        }

        /// <summary>
        /// Deletes the room.
        /// </summary>
        /// <param name="room">The room.</param>
        public void DeleteRoom(ref Room room)
        {
            room = null;
        }

        /// <summary>
        /// Creates the order.
        /// </summary>
        /// <param name="OrderID">The order identifier.</param>
        /// <param name="Sum">The sum.</param>
        /// <param name="Hotel">The hotel.</param>
        /// <param name="User">The user.</param>
        /// <param name="OrderNumber">The order number.</param>
        /// <param name="Room">The room.</param>
        /// <param name="Start">The start.</param>
        /// <param name="End">The end.</param>
        public void CreateOrder(int OrderID, decimal Sum,
            Hotel Hotel, User User, string OrderNumber,
            Room Room, DateTime Start, DateTime End)
        {
            ConcreteOrder order = new ConcreteOrder(OrderID, Sum, Hotel,
                User, OrderNumber, Room, Start, End);
            User.Orders.Add(order);
            Hotel.Orders.Add(order);
        }

        /// <summary>
        /// Implements the operator ++.
        /// </summary>
        /// <param name="h">The hotel.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Hotel operator ++(Hotel h)
        {
            h.NumberOfStars++;
            return h;
        }

        /// <summary>
        /// Implements the operator --.
        /// </summary>
        /// <param name="h">The hotel.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Hotel operator --(Hotel h)
        {
            h.NumberOfStars--;
            return h;
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="h1">The 1 hotel.</param>
        /// <param name="h2">The 2 hotel.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator ==(Hotel h1, Hotel h2)
        {
            // If parameter is null, return false.
            if (h1 is null || h2 is null)
            {
                return false;
            }

            // Optimization for a common success case.
            if (ReferenceEquals(h1, h2))
            {
                return true;
            }

            // If run-time types are not exactly the same, return false.
            if (h1.GetType() != h2.GetType())
            {
                return false;
            }

            // Return true if the fields match.
            return (h1.NumberOfStars == h2.NumberOfStars)
                && (h1.Rating == h2.Rating);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="h1">The 1 hotel.</param>
        /// <param name="h2">The 2 hotel.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator !=(Hotel h1, Hotel h2)
        {
            // If parameter is null, return true.
            if (!(h1 is null) && !(h2 is null))
            {
                // Optimization for a common success case.
                if (ReferenceEquals(h1, h2))
                {
                    return false;
                }

                // If run-time types are not exactly the same, return true.
                if (h1.GetType() != h2.GetType())
                {
                    return true;
                }

                // Return true if the fields match.
                return !((h1.NumberOfStars == h2.NumberOfStars)
                    && (h1.Rating == h2.Rating));
            }
            return true;
        }

        /// <summary>
        /// Delegate for showing some string
        /// </summary>
        /// <param name="messageString">The message string.</param>
        public delegate void MessageHandler(string messageString);

        /// <summary>
        /// Shows some string.
        /// </summary>
        /// <param name="messageString">The message string.</param>
        /// <param name="handler">The handler.</param>
        public static void ShowSomeString(string messageString, MessageHandler handler)
        {
            handler(messageString);
        }
    }
}

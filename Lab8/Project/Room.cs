﻿// Licensed to the Mezidia Foundation under one or more agreements.
// The Mezidia Foundation licenses this file to you under the MIT license.

using System;

namespace Hotel
{
    public class Room
    {
        private delegate void Message(string text);
        private static void ShowMessage(string text)
        {
            Console.WriteLine(text);
        }

        private readonly Message _dlg = ShowMessage;

        private int _roomID;

        /// <summary>
        /// get and set roomID
        /// check if value is positive
        /// </summary>
        public int RoomID
        {
            get
            {
                return _roomID;
            }
            set
            {
                if (value > 0)
                {
                    _roomID = value;
                }
                else
                {
                    _dlg("ID має бути бiльшим вiд 0");
                }
            }
        }

        private int _roomNumber;

        /// <summary>
        /// get and set roomNumber
        /// check if value is positive
        /// </summary>
        public int RoomNumber
        {
            get
            {
                return _roomNumber;
            }
            set
            {
                if (value > 0)
                {
                    _roomNumber = value;
                }
                else
                {
                    _dlg("Номер кiмнати має бути бiльшим від 0");
                }
            }
        }

        private string _roomName;

        /// <summary>
        /// get and set roomName
        /// check if value is not empty
        /// </summary>
        public string RoomName
        {
            get
            {
                return _roomName;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) &&
                    !string.IsNullOrWhiteSpace(value))
                {
                    _roomName = value;
                }
                else
                {
                    _dlg("Назва кiмнати не повинна бути пустою");
                }
            }
        }

        private int _roomSize;

        /// <summary>
        /// get and set roomSize
        /// check if value is positive
        /// </summary>
        public int RoomSize
        {
            get
            {
                return _roomSize;
            }
            set
            {
                if (value > 0)
                {
                    _roomSize = value;
                }
                else
                {
                    _dlg("Розмiр кiмнати має бути бiльшим вiд 0");
                }
            }
        }

        private Hotel _hotel;

        /// <summary>
        /// get and set Hotel
        /// check if value is not empty
        /// </summary>
        public Hotel Hotel
        {
            get
            {
                return _hotel;
            }
            set
            {
                if (value != null)
                {
                    _hotel = value;
                }
                else
                {
                    _dlg("Кiмната має належати до готелю");
                }
            }
        }

        private bool? _tv;

        /// <summary>
        /// get and set TV
        /// check if value is not empty
        /// </summary>
        public bool? TV
        {
            get
            {
                return _tv;
            }
            set
            {
                if (value.HasValue)
                {
                    _tv = value;
                }
                else
                {
                    _dlg("Введiть значення про наявнiсть телевiзора");
                }
            }
        }

        private string _roomType;

        /// <summary>
        /// get and set roomType
        /// check if value is not empty
        /// </summary>
        public string RoomType
        {
            get
            {
                return _roomType;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) &&
                    !string.IsNullOrWhiteSpace(value))
                {
                    _roomType = value;
                }
                else
                {
                    _dlg("Задайте тип кiмнати");
                }
            }
        }

        private int _numberOfBeds;

        /// <summary>
        /// get and set numberOfBeds
        /// check if value is positive
        /// </summary>
        public int NumberOfBeds
        {
            get
            {
                return _numberOfBeds;
            }
            set
            {
                if (value > 0)
                {
                    _numberOfBeds = value;
                }
                else
                {
                    _dlg("Кiлькість спальних мiсць " +
                        "має бути бiльша вiд 0");
                }
            }
        }

        private bool? _balcony;

        /// <summary>
        /// get and set balcony
        /// check if value is not empty
        /// </summary>
        public bool? Balcony
        {
            get
            {
                return _balcony;
            }
            set
            {
                if (value.HasValue)
                {
                    _balcony = value;
                }
                else
                {
                    _dlg("Введiть значення" +
                        " про наявнiсть балкону");
                }
            }
        }

        // Перевантажуємо логічний оператор &
        public static bool operator &(Room room1, Room room2)
        {
            return room1.TV == true && room2.TV == true;
        }

        // Перевантажуємо логічний оператор !
        public static bool operator !(Room room)
        {
            return room._balcony == true;
        }

        // Перевантажуємо оператор true
        public static bool operator true(Room room)
        {
            return room.TV == true;
        }

        // Перевантажуємо оператор false
        public static bool operator false(Room room)
        {
            return room.TV == false;
        }

        /// <summary>
        /// Initialization Constructor
        /// </summary>
        /// <param name="roomID"></param>
        /// <param name="roomNumber"></param>
        /// <param name="roomName"></param>
        /// <param name="roomSize"></param>
        /// <param name="hotel"></param>
        /// <param name="tv"></param>
        /// <param name="roomType"></param>
        /// <param name="numberOfBeds"></param>
        /// <param name="balcony"></param>
        public Room(int roomID, int roomNumber, string roomName,
            int roomSize, Hotel hotel, bool? tv, string roomType,
            int numberOfBeds, bool? balcony)
        {
            RoomID = roomID;
            RoomNumber = roomNumber;
            RoomName = roomName;
            RoomSize = roomSize;
            Hotel = hotel;
            TV = tv;
            RoomType = roomType;
            NumberOfBeds = numberOfBeds;
            Balcony = balcony;

            _dlg($"Додано кiмнату номер {RoomNumber} готелю " +
                $"{Hotel.HotelName}");
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="room"></param>
        public Room(Room room)
        {
            RoomID = room.RoomID;
            RoomNumber = room.RoomNumber;
            RoomName = room.RoomName;
            RoomSize = room.RoomSize;
            Hotel = room.Hotel;
            TV = room.TV;
            RoomType = room.RoomType;
            NumberOfBeds = room.NumberOfBeds;
            Balcony = room.Balcony;

            _dlg("Додано копiю кiмнати");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Room"/> class.
        /// </summary>
        public Room() { }

        /// <summary>
        /// Overload + operator to easily combine two rooms
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        public static Room operator +(Room r1, Room r2)
        {
            r1.Hotel.Rooms.Remove(r1);
            r2.Hotel.Rooms.Remove(r2);

            int id = r1.RoomID;
            int number = r1.RoomNumber;
            string name = r1.RoomName + " об'єднана з " + r2.RoomName;
            int size = r1.RoomSize + r2.RoomSize;
            Hotel hotel = r1.Hotel;
            bool? tv = r1.TV | r2.TV;
            string type = r1.RoomType;
            int beds = r1.NumberOfBeds + r2.NumberOfBeds;
            bool? balcony = r1.Balcony | r2.Balcony;

            Room newRoom = new Room(id, number, name,
                size, hotel, tv, type, beds, balcony)
            {
                RoomID = id,
                RoomNumber = number,
                RoomName = name,
                RoomSize = size,
                Hotel = hotel,
                TV = tv,
                RoomType = type,
                NumberOfBeds = beds,
                Balcony = balcony
            };

            r1.Hotel.Rooms.Add(newRoom);

            Console.WriteLine($"Кiмнати {r1.RoomName} та {r2.RoomName} готелю " +
                $"{r1.Hotel.HotelName} були видаленi");

            r1.Hotel.DeleteRoom(ref r1);
            r2.Hotel.DeleteRoom(ref r2);

            return newRoom;
        }

        /// Implements the operator ++.
        /// </summary>
        /// <param name="r">room.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Room operator ++(Room r)
        {
            r.NumberOfBeds++;
            return r;
        }

        /// <summary>
        /// Implements the operator --.
        /// </summary>
        /// <param name="r">room.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Room operator --(Room r)
        {
            r.NumberOfBeds--;
            return r;
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="r1">The 1 room.</param>
        /// <param name="r2">The 2 room.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator ==(Room r1, Room r2)
        {
            // If parameter is null, return false.
            if (r1 is null || r2 is null)
            {
                return false;
            }

            // Optimization for a common success case.
            if (ReferenceEquals(r1, r2))
            {
                return true;
            }

            // If run-time types are not exactly the same, return false.
            if (r1.GetType() != r2.GetType())
            {
                return false;
            }

            // Return true if the fields match.
            return (r1.NumberOfBeds == r2.NumberOfBeds)
                && (r1.RoomSize == r2.RoomSize) &&
                (r1.TV == r2.TV) && (r1.Balcony == r2.Balcony);
        }

        public static bool operator !=(Room r1, Room r2)
        {
            // If parameter is null, return true.
            if (r1 is null || r2 is null)
            {
                return true;
            }

            // Optimization for a common success case.
            if (ReferenceEquals(r1, r2))
            {
                return false;
            }

            // If run-time types are not exactly the same, return true.
            if (r1.GetType() != r2.GetType())
            {
                return true;
            }

            // Return true if the fields match.
            return !((r1.NumberOfBeds == r2.NumberOfBeds)
                && (r1.RoomSize == r2.RoomSize) &&
                (r1.TV == r2.TV) && (r1.Balcony == r2.Balcony));
        }

        public delegate void MessageHandler(string messageString);

        public static void ShowSomeString(string messageString, MessageHandler handler)
        {
            handler(messageString);
        }

        public double SpaceKoeff => _numberOfBeds == 0 ? 1 : (double)_roomSize / _numberOfBeds;
        public delegate bool IsEqual(DayOfWeek x);

        public void CheckHotelPrice(IsEqual func)
        {
            if (func(DateTime.Now.DayOfWeek))
            {
                _dlg("Сьогоднi меншi цiни!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Room
    {
        private int roomID;

        /// <summary>
        /// get and set roomID
        /// check if value is positive
        /// </summary>
        public int RoomID
        {
            get
            {
                return roomID;
            }
            set
            {
                if (value > 0)
                {
                    roomID = value;
                }
                else
                {
                    Console.WriteLine("ID має бути більшим від 0");
                }
            }
        }

        private int roomnumber;

        /// <summary>
        /// get and set roomnumber
        /// check if value is positive
        /// </summary>
        public int RoomNumber
        {
            get
            {
                return roomnumber;
            }
            set
            {
                if (value > 0)
                {
                    roomnumber = value;
                }
                else
                {
                    Console.WriteLine("Номер кімнати має бути більшим від 0");
                }
            }
        }

        private string roomname;

        /// <summary>
        /// get and set roomname
        /// check if value is not empty
        /// </summary>
        public string RoomName
        {
            get
            {
                return roomname;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    roomname = value;
                }
                else
                {
                    Console.WriteLine("Назва кімнати не повинна бути пустою");
                }
            }
        }

        private int roomsize;

        /// <summary>
        /// get and set roomsize
        /// check if value is positive
        /// </summary>
        public int RoomSize
        {
            get
            {
                return roomsize;
            }
            set
            {
                if (value > 0)
                {
                    roomsize = value;
                }
                else
                {
                    Console.WriteLine("Розмір кімнати має бути більшим від 0");
                }
            }
        }
        private Hotel hotel;

        /// <summary>
        /// get and set hotel
        /// check if value is not empty
        /// </summary>
        public Hotel Hotel
        {
            get
            {
                return hotel;
            }
            set
            {
                if (value != null)
                {
                    hotel = value;
                }
                else
                {
                    Console.WriteLine("Кімната має належати до готелю");
                }
            }
        }
        private bool? tv;

        /// <summary>
        /// get and set tv
        /// check if value is not empty
        /// </summary>
        public bool? TV
        {
            get
            {
                return tv;
            }
            set
            {
                if (value.HasValue)
                {
                    tv = value;
                }
                else
                {
                    Console.WriteLine("Введіть значення про наявність телевізора");
                }
            }
        }

        private string roomtype;

        /// <summary>
        /// get and set roomtype
        /// check if value is not empty
        /// </summary>
        public string RoomType
        {
            get
            {
                return roomtype;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    roomtype = value;
                }
                else
                {
                    Console.WriteLine("Задайте тип кімнати");
                }
            }
        }
        private int numberofbeds;

        /// <summary>
        /// get and set numberofbeds
        /// check if value is positive
        /// </summary>
        public int NumberOfBeds
        {
            get
            {
                return numberofbeds;
            }
            set
            {
                if (value > 0)
                {
                    numberofbeds = value;
                }
                else
                {
                    Console.WriteLine("Кількість спальних місць має бути більша від 0");
                }
            }
        }

        private bool? balcony;

        /// <summary>
        /// get and set balcony
        /// check if value is not empty
        /// </summary>
        public bool? Balcony
        {
            get
            {
                return balcony;
            }
            set
            {
                if (value.HasValue)
                {
                    balcony = value;
                }
                else
                {
                    Console.WriteLine("Введіть значення про наявність балкону");
                }
            }
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
        public Room(int roomID, int roomNumber, string roomName, int roomSize, Hotel hotel, bool? tv, string roomType, int numberOfBeds, bool? balcony)
        {
            this.RoomID = roomID;
            this.RoomNumber = roomNumber;
            this.RoomName = roomName;
            this.RoomSize = roomSize;
            this.Hotel = hotel;
            this.TV = tv;
            this.RoomType = roomType;
            this.NumberOfBeds = numberOfBeds;
            this.Balcony = balcony;

            Console.WriteLine("Додано кімнату");
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

            Console.WriteLine("Додано копію кімнати");
        }
    }
}

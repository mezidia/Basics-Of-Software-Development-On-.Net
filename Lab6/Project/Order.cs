using System;

namespace Hotel
{
    public abstract class AbstractOrder
    {
        private int orderID;

        /// <summary>
        /// We need this to get and set orderID.
        /// Also We check if value isn't null
        /// </summary>
        public int OrderID
        {
            get
            {
                return orderID;
            }

            set
            {
                if (value.ToString() != null && value > 0)
                {
                    orderID = value;
                }
                else
                {
                    Console.WriteLine("Введiть непорожнiй ID");
                }
            }
        }

        private decimal sum;

        /// <summary>
        /// We need this to get and set Sum.
        /// Also We check if value isn't null
        /// </summary>
        public decimal Sum
        {
            get
            {
                return sum;
            }

            set
            {
                if (value.ToString() != null && value > 0)
                {
                    sum = value;
                }
                else
                {
                    Console.WriteLine("Введiть непорожню суму");
                }
            }
        }

        private Hotel hotel;

        /// <summary>
        /// We need this to get and set Hotel.
        /// Also We check if value isn't null
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
                    Console.WriteLine("Введiть непорожнiй готель");
                }
            }
        }

        private User user;

        /// <summary>
        /// We need this to get and set User.
        /// Also We check if value isn't null
        /// </summary>
        public User User
        {
            get
            {
                return user;
            }

            set
            {
                if (value != null)
                {
                    user = value;
                }
                else
                {
                    Console.WriteLine("Введiть непорожнього користувача");
                }
            }
        }

        private string orderNumber;

        /// <summary>
        /// We need this to get and set OrderNumber.
        /// Also We check if value isn't null
        /// </summary>
        public string OrderNumber
        {
            get
            {
                return orderNumber;
            }

            set
            {
                if (value != null && value.Length != 0)
                {
                    orderNumber = value;
                }
                else
                {
                    Console.WriteLine("Введiть непорожнiй номер замовлення");
                }
            }
        }

        private Room room;

        /// <summary>
        /// We need this to get and set Order.
        /// Also We check if value isn't null
        /// </summary>
        public Room Room
        {
            get
            {
                return room;
            }

            set
            {
                if (value != null)
                {
                    room = value;
                }
                else
                {
                    Console.WriteLine("Введiть непорожню кiмнату");
                }
            }
        }

        private DateTime dateStart;

        /// <summary>
        /// We need this to get and set Order.
        /// Also We check if value isn't null
        /// </summary>
        public DateTime DateStart
        {
            get
            {
                return dateStart;
            }

            set
            {
                if (value != null)
                {
                    DateTime.TryParse(value.ToString(), out dateStart);
                }
                else
                {
                    Console.WriteLine("Введiть непорожню дату початку");
                }
            }
        }

        private DateTime dateEnd;

        /// <summary>
        /// We need this to get and set Order.
        /// Also We check if value isn't null
        /// </summary>
        public DateTime DateEnd
        {
            get
            {
                return dateEnd;
            }

            set
            {
                if (value != null)
                {
                    DateTime.TryParse(value.ToString(), out dateEnd);
                }
                else
                {
                    Console.WriteLine("Введiть непорожню дату закiнчення");
                }
            }
        }

        // Перевантажуємо логічний оператор !
        public static bool operator !(AbstractOrder order)
        {
            DateTime now = DateTime.Now;
            System.TimeSpan difference = order.DateEnd.Subtract(now);
            if (difference.TotalDays > 0)
                return false;
            return true;
        }

        // Перевантажуємо оператор true
        public static bool operator true(AbstractOrder order)
        {
            DateTime now = DateTime.Now;
            System.TimeSpan difference = order.DateEnd.Subtract(now);
            if (difference.TotalDays > 0)
                return true;
            return false;
        }

        // Перевантажуємо оператор false
        public static bool operator false(AbstractOrder order)
        {
            DateTime now = DateTime.Now;
            System.TimeSpan difference = order.DateEnd.Subtract(now);
            if (difference.TotalDays > 0)
                return false;
            return true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractOrder"/> class.
        /// </summary>
        /// <param name="orderID">The order identifier.</param>
        /// <param name="sum">The sum.</param>
        /// <param name="hotel">The hotel.</param>
        /// <param name="user">The user.</param>
        /// <param name="orderNumber">The order number.</param>
        /// <param name="room">The room.</param>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        public AbstractOrder(int orderID, decimal sum,
            Hotel hotel, User user, string orderNumber,
            Room room, DateTime start, DateTime end)
        {
            OrderID = orderID;
            Sum = sum;
            Hotel = hotel;
            User = user;
            OrderNumber = orderNumber;
            Room = room;
            DateStart = start;
            DateEnd = end;
        }

        /// <summary>
        /// Determines whether this instance is expired.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is expired; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool IsExpired()
        {
            if (DateEnd < DateTime.Now)
            {
                Console.WriteLine("Абстрактне бронювання вичерпано");
                return true;
            }
            Console.WriteLine("Абстрактне бронювання не вичерпано");
            return false;
        }

        /// <summary>
        /// Return string with with an affiliation to something
        /// From abstract class
        /// </summary>
        /// <returns>string</returns>
        public virtual string BelongsTo()
        {
            string result = $"Це абстрактне бронювання належить" +
                $" користувачу {User.UserName} та готелю {Hotel.HotelName}";
            Console.WriteLine(result);
            return result;
        }
    }

    /// <summary>
    /// Class, where We use overrided methods
    /// </summary>
    /// <seealso cref="Hotel.AbstractOrder" />
    public class ConcreteOrder : AbstractOrder
    {
        public ConcreteOrder(int orderID, decimal sum,
            Hotel hotel, User user, string orderNumber,
            Room room, DateTime start, DateTime end) :
            base(orderID, sum, hotel, user, orderNumber,
            room, start, end)
        {
            OrderID = orderID;
            Sum = sum;
            Hotel = hotel;
            User = user;
            OrderNumber = orderNumber;
            Room = room;
            DateStart = start;
            DateEnd = end;

            Console.WriteLine($"Конкретне бронювання користувача " +
                $"номер {OrderNumber} {User.UserName} готово");
        }

        /// <summary>
        /// Determines whether this instance is expired.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is expired; otherwise, <c>false</c>.
        /// </returns>
        public override bool IsExpired()
        {
            if (DateEnd < DateTime.Now)
            {
                Console.WriteLine("Конкретне бронювання вичерпано");
                return true;
            }
            Console.WriteLine("Конкретне бронювання не вичерпано");
            return false;
        }

        /// <summary>
        /// Return string with with an affiliation to something
        /// From concrete class
        /// </summary>
        /// <returns>string</returns>
        public override string BelongsTo()
        {
            string result = $"Це конкретне бронювання належить" +
                $" користувачу {User.UserName} та готелю {Hotel.HotelName}";
            Console.WriteLine(result);
            return result;
        }
    }

    /// <summary>
    /// Class, where We use methods from abstract class
    /// </summary>
    /// <seealso cref="Hotel.AbstractOrder" />
    public class NotSoConcreteOrder : AbstractOrder
    {
        public NotSoConcreteOrder(int orderID, decimal sum,
            Hotel hotel, User user, string orderNumber,
            Room room, DateTime start, DateTime end) :
            base(orderID, sum, hotel, user, orderNumber,
            room, start, end)
        {
            OrderID = orderID;
            Sum = sum;
            Hotel = hotel;
            User = user;
            OrderNumber = orderNumber;
            Room = room;
            DateStart = start;
            DateEnd = end;

            Console.WriteLine($"Не дуже конкретне бронювання " +
                $"користувача номер {OrderNumber} " +
                $"{User.UserName} готово");
        }
        public void CheckPackPrice(Room room, decimal Sum)
        {          
                Console.WriteLine("Сьогоднi меншi цiни!");

        }
    }

}

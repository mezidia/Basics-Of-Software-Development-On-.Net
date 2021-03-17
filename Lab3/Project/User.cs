using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Hotel
{
    public class User
    {
        private string userMail;

        /// <summary>
        /// We need this to get and set UserMail.
        /// Also We check if value is a valid mail address
        /// </summary>
        public string UserMail
        {
            get
            {
                return userMail;
            }
            set
            {
                try
                {
                    var address = new System.Net.Mail.MailAddress(value);
                    userMail = address.Address;
                }
                catch
                {
                    Console.WriteLine("Введiть дiйсну електронну пошту");
                }
            }
        }

        private string userPhone;

        /// <summary>
        /// We need this to get and set UserPhone.
        /// Also We check if value matches the regular expression
        /// </summary>
        public string UserPhone
        {
            get
            {
                return userPhone;
            }
            set
            {
                if (value != null && Regex.IsMatch(value, @"^(\+[0-9]{9})$"))
                {
                    userPhone = value;
                }
                else
                {
                    Console.WriteLine("Введiть коректний номер телефону");
                }
            }
        }

        private string password;

        /// <summary>
        /// We need this to get and set Password.
        /// Also We check if value has number, upper case and minimum 8 characters
        /// </summary>
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                var hasNumber = new Regex(@"[0-9]+");
                var hasUpperChar = new Regex(@"[A-Z]+");
                var hasMinimum8Chars = new Regex(@".{8,}");

                if (hasNumber.IsMatch(value) && hasUpperChar.IsMatch(value)
                    && hasMinimum8Chars.IsMatch(value))
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Введiть коректний пароль. " +
                        "Має бути мiнiмум одна цифра, одна велика " +
                        "буква, i довжина паролю має бути мiнiмум 8 символiв.");
                }
            }
        }

        private string login;

        /// <summary>
        /// We need this to get and set Login.
        /// Also We check if value isn't null
        /// </summary>
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (value != null)
                {
                    login = value;
                }
                else
                {
                    Console.WriteLine("Введiть непорожнiй логiн");
                }
            }
        }

        private int userID;

        /// <summary>
        /// We need this to get and set UserId.
        /// Also We check if value isn't null
        /// </summary>
        public int UserID
        {
            get
            {
                return userID;
            }
            set
            {
                if (value.ToString() != null && value > 0)
                {
                    userID = value;
                }
                else
                {
                    Console.WriteLine("Введiть непорожнiй iдентифiкатор");
                }
            }
        }

        private short userType;

        /// <summary>
        /// We need this to get and set UserType.
        /// Also We check if value isn't null
        /// </summary>
        public short UserType
        {
            get
            {
                return userType;
            }
            set
            {
                if (value.ToString() != null)
                {
                    userType = value;
                }
                else
                {
                    Console.WriteLine("Введiть непорожнiй тип");
                }
            }

        }

        private string userName;

        /// <summary>
        /// We need this to get and set UserName.
        /// Also We check if value isn't null
        /// </summary>
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                if (value != null)
                {
                    userName = value;
                }
                else
                {
                    Console.WriteLine("Введiть непорожне iм'я");
                }
            }
        }

        public List<Order> Orders = new List<Order>();

        /// <summary>
        /// Constructor by default
        /// </summary>
        public User()
        {
            Console.WriteLine("Користувача за замовченням створено");
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="tech"></param>
        public User(User user)
        {
            userID = user.UserID;
            userType = user.UserType;
            UserName = user.UserName;
            UserMail = user.UserMail;
            UserPhone = user.UserPhone;

            Console.WriteLine($"Копiю користувача {UserName} створено");
        }

        /// <summary>
        /// Initialization Constructor
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="UserType"></param>
        /// <param name="UserName"></param>
        /// <param name="UserMail"></param>
        /// <param name="UserPhone"></param>
        public User(int userID, short userType,
                    string userName, string userMail, string userPhone)
        {
            UserID = userID;
            UserType = userType;
            UserName = userName;
            UserMail = userMail;
            UserPhone = userPhone;

            Console.WriteLine($"Користувач {UserName} створений");
        }

        public void SearchForInfo() { }
        public void Book() { }
        public void CheckBooking() { }
        public void CancelBooking() { }
        public void LogOut() { }
        public void AddHotel() { }
        public void AddCity(string city) { }
        private void SingUpLogin() { }
        public void UpdateHotelInfo() { }
        public void CheckHotelBooking() { }
        public void UpdateRoom() { }
        public void ChangeAccess() { }
        public void RemoveHotel() { }
    }
}

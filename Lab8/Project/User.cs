// Licensed to the Mezidia Foundation under one or more agreements.
// The Mezidia Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Hotel
{
    public class User
    {
        private delegate void Message(string text);
        private static void ShowMessage(string text)
        {
            Console.WriteLine(text);
        }

        private readonly Message _dlg = ShowMessage;
        private string _userMail;

        /// <summary>
        /// We need this to get and set UserMail.
        /// Also We check if value is a valid mail address
        /// </summary>
        public string UserMail
        {
            get
            {
                return _userMail;
            }
            set
            {
                try
                {
                    var address = new System.Net.Mail.MailAddress(value);
                    _userMail = address.Address;
                }
                catch
                {
                    _dlg("Введiть дiйсну електронну пошту");
                }
            }
        }

        private string _userPhone;

        /// <summary>
        /// We need this to get and set UserPhone.
        /// Also We check if value matches the regular expression
        /// </summary>
        public string UserPhone
        {
            get
            {
                return _userPhone;
            }
            set
            {
                if (value != null && Regex.IsMatch(value, @"^(\+[0-9]{9})$"))
                {
                    _userPhone = value;
                }
                else
                {
                    _dlg("Введiть коректний номер телефону");
                }
            }
        }

        private string _password;

        /// <summary>
        /// We need this to get and set Password.
        /// Also We check if value has number, upper case and minimum 8 characters
        /// </summary>
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                var hasNumber = new Regex(@"[0-9]+");
                var hasUpperChar = new Regex(@"[A-Z]+");
                var hasMinimum8Chars = new Regex(@".{8,}");

                if (hasNumber.IsMatch(value) && hasUpperChar.IsMatch(value)
                    && hasMinimum8Chars.IsMatch(value))
                {
                    _password = value;
                }
                else
                {
                    _dlg("Введiть коректний пароль. " +
                        "Має бути мiнiмум одна цифра, одна велика " +
                        "буква, i довжина паролю має бути мiнiмум 8 символiв.");
                }
            }
        }

        private string _login;

        /// <summary>
        /// We need this to get and set Login.
        /// Also We check if value isn't null
        /// </summary>
        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                if (value != null)
                {
                    _login = value;
                }
                else
                {
                    _dlg("Введiть непорожнiй логiн");
                }
            }
        }

        private int _userID;

        /// <summary>
        /// We need this to get and set UserId.
        /// Also We check if value isn't null
        /// </summary>
        public int UserID
        {
            get
            {
                return _userID;
            }
            set
            {
                if (value.ToString() != null && value > 0)
                {
                    _userID = value;
                }
                else
                {
                    _dlg("Введiть непорожнiй iдентифiкатор");
                }
            }
        }

        private short _userType;

        /// <summary>
        /// We need this to get and set UserType.
        /// Also We check if value isn't null
        /// </summary>
        public short UserType
        {
            get
            {
                return _userType;
            }
            set
            {
                if (value.ToString() != null)
                {
                    _userType = value;
                }
                else
                {
                    _dlg("Введiть непорожнiй тип");
                }
            }
        }

        private string _userName;

        /// <summary>
        /// We need this to get and set UserName.
        /// Also We check if value isn't null
        /// </summary>
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                if (value != null)
                {
                    _userName = value;
                }
                else
                {
                    Console.WriteLine("Введiть непорожне iм'я");
                }
            }
        }

        public bool IsAuthorized { get; private set; } = false;

        public List<ConcreteOrder> Orders = new List<ConcreteOrder>();

        // Перевантажуємо логічний оператор &
        public static bool operator &(User user1, User user2)
        {
            return string.IsNullOrEmpty(user1.UserMail) != true ||
                string.IsNullOrEmpty(user1.UserPhone) != true ||
                string.IsNullOrEmpty(user2.UserMail) != true ||
                string.IsNullOrEmpty(user2.UserPhone) != true;
        }

        // Перевантажуємо логічний оператор !
        public static bool operator !(User user)
        {
            return string.IsNullOrEmpty(user.UserMail) == true &&
                string.IsNullOrEmpty(user.UserPhone) == true;
        }

        // Перевантажуємо оператор true
        public static bool operator true(User user)
        {
            return string.IsNullOrEmpty(user.UserMail) != true ||
                string.IsNullOrEmpty(user.UserPhone) != true;
        }

        // Перевантажуємо оператор false
        public static bool operator false(User user)
        {
            return string.IsNullOrEmpty(user.UserMail) == true
                && string.IsNullOrEmpty(user.UserPhone) == true;
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="tech"></param>
        public User(User user)
        {
            _userID = user.UserID;
            _userType = user.UserType;
            UserName = user.UserName;
            UserMail = user.UserMail;
            UserPhone = user.UserPhone;

            _dlg($"Копiю користувача {UserName} створено");
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

            _dlg($"Користувач {UserName} створений");
        }

        /// <summary>
        /// Constructor by default
        /// </summary>
        public User()
        {
            _dlg("Користувача за замовченням створено");
        }

        public void LogIn(string login, string password)
        {
            if (string.IsNullOrEmpty(login))
            {
                throw new ArgumentException("Задано пустий логiн");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Задано пустий пароль");
            }

            if (login.Equals(_login) && password.Equals(_password))
            {
                IsAuthorized = true;
                Console.WriteLine("Користувача авторизовано!");
            }
            else
            {
                throw new Project.LogInException("Користупача не авторизовано, перевiрте данi!");
            }
        }

        public void SearchForInfo() { }
        public void Book() { }
        public void CheckBooking() { }
        public void CancelBooking() { }
        public void LogOut() { }
        public void AddHotel() { }
        public void AddCity() { }
        public void SingUpLogin() { }
        public void UpdateHotelInfo() { }
        public void CheckHotelBooking() { }
        public void UpdateRoom() { }
        public void ChangeAccess() { }
        public void RemoveHotel() { }
    }

    public class Customer : User
    {
        public short customerType = 2;
        public string UserTypeName = "Customer";

        public Customer(int userID, string userMail,
            string userName, string userPhone)
        {
            UserID = userID;
            UserType = customerType;
            UserName = userName;
            UserMail = userMail;
            UserPhone = userPhone;

            Console.WriteLine($"Користувач {UserTypeName}" +
                $" на iм'я {userName} створений");
        }
    }

    public class Admin : User
    {
        public short adminType = 1;
        public string UserTypeName = "Admin";

        public Admin(int userID, string userMail,
            string userName, string userPhone)
        {
            UserID = userID;
            UserType = adminType;
            UserName = userName;
            UserMail = userMail;
            UserPhone = userPhone;

            Console.WriteLine($"Користувач {UserTypeName}" +
                $" на iм'я {userName} створений");
        }
    }
}

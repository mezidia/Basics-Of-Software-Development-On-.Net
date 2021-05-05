using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Hotel
{
	public class User
	{
		delegate void Message(string text);
		private static void ShowMessage(string text)
		{
			Console.WriteLine(text);
		}
		Message Dlg = ShowMessage;

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
					Dlg("Введiть дiйсну електронну пошту");
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
					Dlg("Введiть коректний номер телефону");
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
					Dlg("Введiть коректний пароль. " +
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
					Dlg("Введiть непорожнiй логiн");
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
					Dlg("Введiть непорожнiй iдентифiкатор");
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
					Dlg("Введiть непорожнiй тип");
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

		public List<ConcreteOrder> Orders = new List<ConcreteOrder>();

		// Перевантажуємо логічний оператор &
		public static bool operator &(User user1, User user2)
		{
			if (string.IsNullOrEmpty(user1.UserMail) == true &&
				string.IsNullOrEmpty(user1.UserPhone) == true &&
				string.IsNullOrEmpty(user2.UserMail) == true &&
				string.IsNullOrEmpty(user2.UserPhone) == true)
				return false;
			return true;
		}

		// Перевантажуємо логічний оператор !
		public static bool operator !(User user)
		{
			if (string.IsNullOrEmpty(user.UserMail) == true &&
				string.IsNullOrEmpty(user.UserPhone) == true)
				return true;
			return false;
		}

		// Перевантажуємо оператор true
		public static bool operator true(User user)
		{
			if (string.IsNullOrEmpty(user.UserMail) == true &&
				string.IsNullOrEmpty(user.UserPhone) == true)
				return false;
			return true;
		}

		// Перевантажуємо оператор false
		public static bool operator false(User user)
		{
			if (string.IsNullOrEmpty(user.UserMail) == true
				&& string.IsNullOrEmpty(user.UserPhone) == true)
				return true;
			return false;
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

			Dlg($"Копiю користувача {UserName} створено");
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

			Dlg($"Користувач {UserName} створений");
		}

		/// <summary>
		/// Constructor by default
		/// </summary>
		public User()
		{
			Dlg("Користувача за замовченням створено");
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

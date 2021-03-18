using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
	public class User
	{
		public string login;
		public string password;
		public int userID;
		public short userType;
		public string userName;
		public string userMail;
		public string userPhone;
		public List<Order> orders = new List<Order>();

		/// <summary>
		/// Constructor by default
		/// </summary>
		public User()
		{
			Console.WriteLine("Default User is created");
		}

		/// <summary>
		/// Copy constructor
		/// </summary>
		/// <param name="tech"></param>
		public User(User user)
		{
			userID = user.userID;
			userType = user.userType;
			userName = user.userName;
			userMail = user.userMail;
			userPhone = user.userPhone;

			Console.WriteLine("Copy User is created");
		}

		/// <summary>
		/// Initialization Constructor
		/// </summary>
		/// <param name="UserID"></param>
		/// <param name="UserType"></param>
		/// <param name="UserName"></param>
		/// <param name="UserMail"></param>
		/// <param name="UserPhone"></param>
		public User(int UserID, short UserType,
		            string UserName, string UserMail, string UserPhone)
		{
			userID = UserID;
			userType = UserType;
			userName = UserName;
			userMail = UserMail;
			userPhone = UserPhone;

			Console.WriteLine("User is created");
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

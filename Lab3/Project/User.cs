﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
	public class User
	{
		public string Login { get; set; }
		public string Password { get; set; }
		public int UserID { get; set; }
		public short UserType { get; set; }
		public string UserName { get; set; }
		public string UserMail { get; set; }
		public string UserPhone { get; set; }
		public List<Order> Orders = new List<Order>();

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
			UserID = user.UserID;
			UserType = user.UserType;
			UserName = user.UserName;
			UserMail = user.UserMail;
			UserPhone = user.UserPhone;

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
			this.UserID = UserID;
			this.UserType = UserType;
			this.UserName = UserName;
			this.UserMail = UserMail;
			this.UserPhone = UserPhone;

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
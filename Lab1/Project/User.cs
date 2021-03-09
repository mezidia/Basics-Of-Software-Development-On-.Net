using System;
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
        public List<Role> Roles { get; set; } = new List<Role>();
        public User(int UserID, short UserType, string UserName, string UserMail, string UserPhone)
        {
            this.UserID = UserID;
            this.UserType = UserType;
            this.UserName = UserName;
            this.UserMail = UserMail;
            this.UserPhone = UserPhone;
        }
        public void SearchForInfo() { }
        public void Book() { }
        public void CheckBooking() { }
        public void CancelBooking() { }
        public void LogOut() { }
        public void AddHotel() { }
        private void SingUpLogin() { }
        public void UpdateHotelInfo() { }
        public void CheckHotelBooking() { }
        public void UpdateRoom() { }
        public void ChangeAccess() { }
        public void RemoveHotel() { }
    }
}

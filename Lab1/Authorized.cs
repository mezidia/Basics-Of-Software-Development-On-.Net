using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    class  Authorized : User 
    {
        protected string Email;
        protected string Login;
        protected string Password;
        protected int Age;
        protected int PhoneNumber;
        protected int Country;
        protected int Id;
        protected int Permission;
        public void Book() { }
        public void CheckBooking() { }
        public void Review() { }
        public void CancelBooking() { }
        public void LogOut() { }
        public void AddHotel() { } 
    }
}

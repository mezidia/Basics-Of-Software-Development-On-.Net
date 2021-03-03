using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
	public class Role
	{
		public int RoleID { get; set; }
		public string RoleName { get; set; }
		public Role(int RoleID, string RoleName)
		{
			this.RoleID = RoleID;
			this.RoleName = RoleName;
		}
	}
}

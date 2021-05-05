using System;

namespace Hotel.Project
{
	/// <summary>
	/// Order Interface
	/// </summary>
	public interface IOrder
	{
		void CreateOrder(int OrderID, decimal Sum,
			Hotel Hotel, User User, string OrderNumber,
			Room Room, DateTime Start, DateTime End);
	}
}

namespace Hotel.Project
{
	/// <summary>
	/// Room Interface
	/// </summary>
	public interface IRoom
	{
		/// <summary>
		/// Creates the room
		/// </summary>
		/// <param name="roomID"></param>
		/// <param name="roomNumber"></param>
		/// <param name="roomName"></param>
		/// <param name="roomSize"></param>
		/// <param name="hotel"></param>
		/// <param name="tv"></param>
		/// <param name="roomType"></param>
		/// <param name="numberOfBeds"></param>
		/// <param name="balcony"></param>
		void CreateRoom(int roomID, int roomNumber,
		   string roomName, int roomSize, Hotel hotel, bool? tv,
		   string roomType, int numberOfBeds, bool? balcony);
	}
}

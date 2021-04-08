namespace Hotel.Project
{
	public interface IRoom
	{
		void CreateRoom(int roomID, int roomNumber,
		   string roomName, int roomSize, Hotel hotel, bool? tv,
		   string roomType, int numberOfBeds, bool? balcony);
	}
}

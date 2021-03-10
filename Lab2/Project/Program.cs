using System;
namespace Hotel
{
    class MainClass
    {
        static void Main()
        {
            Console.WriteLine("First Lab has started");
            User AdminV = new User(1, 2, "AdminValera", "valera69@gmail.com",
                "+0690696969");
            Hotel Hotel1 = new Hotel(1, "Адам", "вул. Т. Шевченка");
            Hotel1.City = City.Kyiv;
            Console.WriteLine("First Team: Zavalniuk Maxim,\nDmytrenko Roman,\n" +
                "Sichkar Tetiana,\nDominskyi Valentyn");
            Console.ReadLine();
        }
    }
}

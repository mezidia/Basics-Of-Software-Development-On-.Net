using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Hotel.Project
{
	public class Zone
	{
		private string FilePath;
		public Zone(string filePath)
		{
			FilePath = filePath;
		}
		public void readFromFile()
		{
			string text = File.ReadAllText(FilePath);
		}
		public void writeToFile(object text)
		{
			File.WriteAllText(FilePath, (string)text);
		}
	}
}

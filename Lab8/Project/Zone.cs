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
		public void ReadFromFile()
		{
			string text = File.ReadAllText(FilePath);
		}
		public void WriteToFile(object text)
		{
			File.WriteAllText(FilePath, (string)text);
		}
	}
}

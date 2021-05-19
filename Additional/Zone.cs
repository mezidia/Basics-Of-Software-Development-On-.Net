using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Hotel.Project
{
	public class Zone
	{
		#region Lab8-2

		private string FilePath;

		public Zone(string filePath)
		{
			FilePath = filePath;
		}

		public string ReadFromFile()
		{
			return File.ReadAllText(FilePath);
		}

		public void WriteToFile(object text)
		{
			File.WriteAllText(FilePath, (string)text);
		}

		#endregion Lab8-2
	}
}

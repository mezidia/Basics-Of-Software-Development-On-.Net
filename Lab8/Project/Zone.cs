using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Hotel.Project
{
    class Zone
    {
		private string FilePath;
		public Zone(string filePath)
		{
			FilePath = filePath;
		}
		public void readFromFile()
        {
			string text = File.ReadAllText(this.FilePath);
		}
		public void writeToFile(string text)
		{
			File.WriteAllText(this.FilePath, text);
		}
	}
}

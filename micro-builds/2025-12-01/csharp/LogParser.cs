using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace MicroBuilds.LogParser
{
    public class LogParser
    {
        //create a method that can read from the file
        public List<string> ReadLogFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            List<string> myList = new List<string>(lines);

            return myList;
        }
    }
}

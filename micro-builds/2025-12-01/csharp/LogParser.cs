using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Linq; 

namespace MicroBuilds.LogParser
{
    public class LogParser
    {
        //create a method that can read from the file 
        public List<string> ReadLogFile(string path) 
        {

            string[] lines = File.ReadAllLines(path);
            List<string> myList = new List<string>(lines);



            // if(path == null) 
            // {
            //     return emptyStringList;
            // }
            // else 
            // {

            // }

            // foreach (string line in lines)
            // {
            //     Console.WriteLine($"print out every line in file {line}");
            // }
            return myList;
        }


// So I want to create an I/O parser that can do the following: 
    // Write code that reads a file
    // Parses some lines
    // Counts some strings
    // Prints some output
        
    }
}
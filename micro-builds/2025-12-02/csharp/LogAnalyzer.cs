using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MicroBuilds.LogParser
{
    public class LogAnalyzer
    {
        public List<string> ReadLogFile(string path)
        {
            if (path == null)
                return new List<string>();

            string[] fileContent = File.ReadAllLines(path);
            // new List<string>(fileContent) result = fileContent List<string>;
            List<string> result = new List<string>(fileContent);

            return result;
        }

        public void Analyze(List<string> lines)
        {
            //The method should:
            // start all counters at 0
            // receive the List<string> returned from ReadLogFile
            // loop through each line
            // check what level it is (INFO / WARN / ERROR)
            // increment counters
            // print the final summary
            int infoCount = 0;
            int warnCount = 0;
            int errorCount = 0;
            int totalLines = 0;

            foreach (var line in lines)
            {
                if (line.Contains("[INFO]"))
                {
                    infoCount += 1;
                }
                else if (line.Contains("[WARN]"))
                {
                    warnCount += 1;
                }
                else if (line.Contains("[ERROR]"))
                {
                    errorCount += 1;
                }
                totalLines++;
            }
            Console.WriteLine(
                $"Total Lines: {totalLines}, INFO:{infoCount}, WARN:{warnCount}, ERROR:{errorCount}"
            );
        }
    }
}

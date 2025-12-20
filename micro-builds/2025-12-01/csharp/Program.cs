using MicroBuilds.LogParser;

var path = "file.txt";

LogParser parser = new LogParser();

var result = parser.ReadLogFile(path);

foreach (string line in result)
{
    Console.WriteLine($"print out every file line {line}");
}

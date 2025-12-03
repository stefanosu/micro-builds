using MicroBuilds.LogParser;
// Call ReadLogFile(path)
// Store its result in a variable
// Loop that result and print each line

var analyzer = new LogAnalyzer();
var lines = analyzer.ReadLogFile("logs.txt");
analyzer.Analyze(lines);

foreach (var line in lines)
{
    Console.WriteLine($"Print out each file in line. {line}");
}

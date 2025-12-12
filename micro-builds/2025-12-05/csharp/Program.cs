var utils = new FileTools();
var cli = new CliRunner();
cli.commandLineLogic(args, utils);

public class CliRunner
{
    public void commandLineLogic(string[] args, FileTools utils)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Argument empty!");
            return;
        }

        var command = args[0];

        if (command == "greet")
        {
            if (args.Length < 2)
            {
                Console.WriteLine("No name provided!");
            }
            if (args.Length >= 2)
            {
                var name = args[1];
                Console.WriteLine($"Hi {name} how is your spirit?");
            }
        }
        else if (command == "count")
        {
            if (args.Length < 2)
            {
                Console.WriteLine("We need a file.");
            }
            else
            {
                var path = args[1];

                if (!File.Exists(path))
                {
                    Console.WriteLine("File does not exist!");
                }
                else
                {
                    var lines = utils.ReadLogFile(path);
                    Console.WriteLine($"Print the count of lines: {lines.Count}");
                }
            }
        }
        else if (command == "filter")
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Usage: filter <level> <file>");
                return;
            }

            var level = args[1];
            var path = args[2];
            var normalizedLevel = level.ToLower();
            string levelTag;
            int matchCount = 0;

            if (
                normalizedLevel != "info"
                && normalizedLevel != "warn"
                && normalizedLevel != "error"
            )
            {
                Console.WriteLine(
                    $"Unknown level: {normalizedLevel}. Expected: info | warn | error."
                );
                return;
            }

            if (normalizedLevel == "info")
            {
                levelTag = "[INFO]";
            }
            else if (normalizedLevel == "warn")
            {
                levelTag = "[WARN]";
            }
            else
            {
                levelTag = "[ERROR]";
            }

            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exist!");
                return;
            }
            else
            {
                var lines = utils.ReadLogFile(path);

                foreach (var line in lines)
                {
                    if (line.Contains(levelTag))
                    {
                        Console.WriteLine($"Print the line {line}");
                        matchCount++;
                    }
                }
                Console.WriteLine($"Matched {matchCount} lines for {levelTag}.");
            }
        }
    }
}

var utils = new FileTools();
var lines = utils.ReadLogFile(path);


public void commandLineLogic(string[] args, FileTools utils)
{
    var name = "Stefanos";
    var command = args[0];
    var path = args[1];

    if(args.Length >= 1) {
        if(command == "greet")
        {   
            Console.WriteLine($"Hi {name} how is your spirit?");
        } 
    }

    else if(command == "count")
    {
        if(args.Length < 2) 
        {
            Console.WriteLine("We need a file.");
        }
        else if(!File.Exists(path)) 
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

// 1. Check if args has at least 1 argument.
//    If not, print help message and exit.

// 2. Read the first argument → command.

// 3. If command == "greet":
//        Make sure args[1] exists.
//        Print "Hello, <name>!"

// 4. Else if command == "count":
//        Make sure args[1] exists.
//        Check if file exists.
//        Read the file.
//        Print number of lines.

// 5. Else:
//        Print "Unknown command".

// Focus on:
// Argument indexing
// Basic branching
// Clean code structure
// Not mixing JS/C# syntax
// Returning early on invalid input
// Friendly error messages

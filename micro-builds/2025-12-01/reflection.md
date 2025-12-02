## Reflection — 2025-12-01

**What did I build?**

-I created a small C# console app that reads a file from disk, returns the lines as a List<string>, and prints each line to the console.

I set up a new .NET console project and connected it with a custom class (LogParser).


**What surprised me or tripped me up?**

- Understanding namespaces vs folder structure

Instantiating classes and calling methods from Program.cs

Dealing with type mismatches (string[] vs List<string>)

Remembering how return types actually work in C#

Debugging a real runtime error (FileNotFoundException) and fixing the path.


**What did I learn or reinforce about file I/O or parsing?**

- How to use File.ReadAllLines() to load text from disk, I learned that it returns a string[], and the file must exist in the working directory. I had to think about relative paths and where dotnet run actually executes.

How to convert an array into a List<string>, I learned that I can wrap the array in a List<string> constructor. This helped me avoid the type mismatch error and reinforced how C# generics work.

How return values flow from a class method back to Program.cs, I had to return the actual variable (not the type), and then store the result in Program.cs before looping. It helped me internalize how methods communicate data.

The difference between compile-time errors and runtime errors, Compiler errors stopped the build, while the missing file triggered a runtime exception. It helped me see the difference between type issues and path/environment issues.

How file paths are resolved relative to the working directory, I learned that "file.txt" must exist in the project’s execution folder, not the source folder. Understanding the working directory fixed the FileNotFoundException.


**If I revisited this in a week, what would I improve or extend?**

- Add error handling if the file path doesn’t exist

Add parsing for [INFO], [WARN], [ERROR]

Count how many warnings and errors appear

Build a summary method that prints counts or saves results

Possibly turn it into a CLI with arguments.


**How would this change in another language I use (C#, TS/Node, Ruby)?**
- (e.g., different libraries, ergonomics, error handling, etc.)

TS/Node: use fs.readFileSync() or streams, return arrays, easy to map/filter

Ruby: use File.readlines, very concise, elegant for parsing text

C#: more explicit about types, stronger structure, requires clear return types
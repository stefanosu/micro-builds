## Reflection — 2025-12-02

**What did I build?**
I built a log analyzer that reads a log file, parses each line, classifies the log level (INFO/WARN/ERROR), increments counters, and prints a summary. More importantly, I practiced passing collections between methods, separating concerns (reading vs analyzing), and structuring a small C# program cleanly. 


**What surprised me or tripped me up?**
I forgot some of the file I/O steps and forced myself to recall them from memory, which helped reinforce them. The biggest things that tripped me up were type vs instance confusion (List<string> vs new List<string>()), mixing JS syntax with C# (!==, of), and expecting variables from one method (result) to exist in another. Working through these made me understand C#'s structure much more deeply.


**What did I learn or reinforce about file I/O or parsing?**
I reinforced how to read lines from a file, but more importantly I learned how to convert the results into another collection type (string[] → List<string>), how to separate reading logic from processing logic, how to use a return value cleanly in another method, and how to rely on the compiler to guide me toward correct types.


**If I revisited this in a week, what would I improve or extend?**
I would add some tests and error handling and try to see how I could make this more extendable, for 
example if I wanted to add more variables to have to analyze or to be able to read from more than one file.


**How would this change in another language I use (C#, TS/Node, Ruby)?**
TS/Node: Use fs.readFileSync, return arrays directly, easier string manipulation.

Ruby: Very concise — File.readlines and iterating feels natural.

C#: More explicit, forces me to think clearly about types, which helped me avoid fuzzy logic.
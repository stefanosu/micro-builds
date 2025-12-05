## Reflection — 2025-12-03

**What did I build?**
I built a small CLI tool with two commands:

greet <name> → prints a greeting

count <file> → checks whether the file exists, reads it, and prints the number of lines

It handles missing arguments and missing files, and routes everything through a dedicated CliRunner class.


**What surprised me or tripped me up?**
I ran into some confusion around branching logic and how to properly pull values from args and use them in the method.
I also struggled with variable scope — specifically where path was defined and which parts of the program had access to it.

Another challenge was understanding when I needed a Main method versus relying on top-level statements. This helped me better understand how C# handles program entry points.


**What did I learn or reinforce about file I/O or parsing?**
I reinforced that parsing CLI input requires understanding exactly where arguments come from and how they flow through the code.
I also got more comfortable validating input early, checking file existence, and passing helpers (FileTools) into the CLI runner.


**If I revisited this in a week, what would I improve or extend?**
I’d add more error handling and guard clauses.
I’d also restructure the CLI to make adding new commands easier — right now, the branching could get messy as the tool grows.
Using switch expressions or a dictionary of command handlers would make it more extensible.


**How would this change in another language I use (C#, TS/Node, Ruby)?**
In TS/Node, the core idea would be similar but the typing system and the way command-line args are accessed (process.argv) would change the structure a bit.
Ruby would feel more flexible and less strict about types, and probably more concise.
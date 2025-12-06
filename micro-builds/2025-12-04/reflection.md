## Reflection — 2025-12-04

Note: This was the continuation of the CLI tool from Day 3, but today everything “clicked” — wiring, args, scoping, Program.cs logic, instance vs static, and error handling. Even though it continued from the same project, it was a complete and meaningful learning rep with several breakthroughs.


**What did I build?**

Understanding Program.cs wiring 

Using top-level statements correctly 

Fixing scoping issues around path

Understanding instance vs static method calls

Correctly passing args through to the CLI

Overcoming the “no Main method” error

Getting a real CLI command to execute end-to-end


**What surprised me or tripped me up?**

The compiler complaining about a missing entry point

Why path wasn’t accessible in some scopes

Realizing that Program.cs shouldn’t call ReadLogFile

Seeing how arguments actually flow from CLI → Program.cs → CliRunner


**What clicked today?**

This is the part that truly separates Day 4 from 3.

I understood how C# decides what the entry point of a program is.

I learned why top-level statements can replace Main, but also why I was misusing them.

I realized I was treating instance methods like static methods.

Best of all: the full CLI actually ran successfully — end to end. That feeling was huge.


**If I revisited this in a week, what would I improve or extend?**

Today’s improvements are different:

I want to rewrite the wiring from memory.

I’d like to restructure the CLI to support more commands without if/else growth.

I want to rebuild the entire CLI from scratch to test my mastery.


**How would this change in another language I use (C#, TS/Node, Ruby)?**

In TS/Node, the core idea would be similar but the typing system and the way command-line args are accessed (process.argv) would change the structure a bit.
Ruby would feel more flexible and less strict about types, and probably more concise.
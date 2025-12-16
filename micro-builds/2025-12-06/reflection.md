## Reflection — 2025-12-06


**What did I build?**
I refactored the CLI’s if/else command logic into a switch-based router with dedicated handler methods, making the code more extensible, readable, and testable.


**What surprised me or tripped me up?**
I had to make sure that I didn't forget to pass in the correct args and types into the new handler methods.


**What clicked today?**
The separation between command routing and command execution clicked for me, along with a clearer understanding of how method signatures and return behavior shape control flow.


**If I revisited this in a week, what would I improve or extend?**
I would add tests to this to ensure it covers breaking changes and maybe extract this into a command interface.


**How would this change in another language I use (C#, TS/Node, Ruby)?**

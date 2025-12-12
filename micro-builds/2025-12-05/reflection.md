## Reflection — 2025-12-05


**What did I build?**
I built a CLI log filter tool that filters log files by severity level (info, warn, error), validates input, reads files safely, and prints matched lines with a summary count.


**What surprised me or tripped me up?**
I was tripped up by condition logic (especially inverted comparisons), loop semantics, and string comparisons when matching severity tags inside log lines.


**What clicked today?**
Guard clauses, argument parsing, and control flow finally clicked — especially how to fail early and keep the main logic clean.


**If I revisited this in a week, what would I improve or extend?**
I would add unit tests to surface edge cases, refactor logic into helper functions, and make the CLI more extensible (e.g., command parsing via objects or structured configs).


**How would this change in another language I use (C#, TS/Node, Ruby)?**
In TS/Node, argument parsing would rely on process.argv and dynamic typing, while Ruby would allow a more concise but less explicit implementation.
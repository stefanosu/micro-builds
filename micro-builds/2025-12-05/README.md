### Day 5 — Log Filter Tool

## Goal:
# Extend my CLI practice by building a small tool that filters log files by severity level. Commands will look like:

```
filter info sample-log.txt
filter warn sample-log.txt
filter error sample-log.txt
```

### What it should do:

Take two arguments: level + file
Validate the arguments
Check the file exists
Read all lines
Filter lines that match [INFO], [WARN], or [ERROR]
Print the filtered lines
Print how many lines matched


### Why this build matters:

Reinforces CLI architecture
Practices argument parsing
Works with real logs
Introduces functional-style filtering
Prepares me for larger CLI patterns (switch dispatch, command registry, etc.)
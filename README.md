# C# Practice

A collection of C# console project's I'm building while learning .NET, object-oriented programming, and software engineering fundamentals. 
This is an ongoing learning repository, updated as I work through new concepts.

## Projects

### Rock Paper Scissors
A console game against a computer opponent.
- Control flow with 'switch' statements and conditional logic
- Random number generation for the computer's move
- A replay loop so the user can play multiple rounds

### Temperature Converter
Converts between Fahrenheit and Celsius
- Decomposition into small, single-purpose methods
- 'decimal' for accurate numeric handling and 'Math.Round' for formatting
- Robust input validation using 'decimal.TryParse' to handle invalid input gracefully
- A menu loop with re-prompting

### Console To-Do List
A task manager supporting add, view, complete and delete.
- Object-orioented design with a 'ToDoItem' class
- Encapsulation: private state exposed only through methods ('MarkComplete', 'GetDisplayText')
- Working with generic collections ('List<T>')
- Range-checked input validation to safely access list items

### Calculator App
A calculator app supporting add, subtract, divide, multiply and an option to quit
- Separate methods for each operation
- Menu-driven loop using a 'switch' statement with a 'default' case for invalid input
- Robust input validation with 'decimal.TryParse', re-prompting until valid
- Handles division by zero gracefully instead of crashing.

## Built with
- C# / .NET 10
- Visual Studio

# About
I'm a Computer Science graduate building toward a career in software engineering. This repo tracks my hands-on practice as I strengthen my C# and .NET skills.
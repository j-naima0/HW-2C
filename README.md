# HW-2C Interactive Console Menu Application

A C# console application that displays an interactive menu system with user input handling.

## Description

This program creates a console-based interactive menu that allows users to select from four different options. The menu continues to display until the user chooses to quit, providing a simple but functional user interface.

## Features

- Interactive menu with user input
- Four menu options:
  - New Game
  - Load Game  
  - Options
  - Quit
- Input validation for invalid choices
- Loop functionality to return to menu after each selection
- Clean screen transitions
- Formatted display with decorative borders

## How It Works

1. Displays the formatted menu
2. Prompts user for input (1-4)
3. Responds to user selection
4. Returns to menu (except when quitting)
5. Handles invalid input with error messages

## Sample Output

```
**************

Menu:

1 - New Game

2 - Load Game

3 - Options

4 - Quit

**************

Please enter your choice (1-4): 1

You selected: New Game
Press any key to return to menu...
```

## Requirements

- .NET Core/Framework
- C# development environment (Visual Studio, VS Code, etc.)

## How to Run

1. Clone this repository
2. Open the project in your C# development environment
3. Build and run the project
4. Follow the on-screen prompts to navigate the menu
5. Enter 4 to quit the application

## Technologies Used

- C#
- .NET
- Console Application

## Programming Concepts Demonstrated

- User input handling with `Console.ReadLine()`
- Control structures (while loops, switch statements)
- Input validation
- Screen management with `Console.Clear()`
- String comparison and user interaction

## Project Structure

```
HW-2C/
├── Program.cs          # Main program file with menu logic
├── HW-2C.csproj       # Project configuration
└── README.md          # This file
```

## Learning Objectives

This assignment demonstrates:
- Interactive console application development
- User input processing and validation
- Menu-driven program design
- Basic control flow and loops
- Clean user interface design

## Author

Created for C# programming course - HW-2C assignment.

## License

This project is for educational purposes.

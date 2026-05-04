Conway's Game of Life
A simple and efficient implementation of Conway's Game of Life built with C# and Windows Forms. This project simulates the famous cellular automaton devised by mathematician John Conway in 1970.

📋 About the Project
The "Game of Life" is a zero-player game, meaning its evolution is determined by its initial state, requiring no further input. This implementation provides a graphical interface where you can watch how complex patterns emerge from simple rules.

The Rules
Birth: A dead cell with exactly three live neighbors becomes a live cell.

Survival: A live cell with two or three live neighbors lives on to the next generation.

Death by solitude: A live cell with fewer than two live neighbors dies.

Death by overpopulation: A live cell with more than three live neighbors dies.

🛠 Tech Stack
Language: C#

Framework: .NET (Windows Forms)

IDE: Visual Studio 2022

🚀 Getting Started
Prerequisites
.NET SDK (Version 8.0 or higher recommended).

Windows OS (required for Windows Forms).

Installation
Clone the repository:

Bash
git clone https://github.com/SaintMortal/Game-of-life.git
Navigate to the project directory:

Bash
cd Game-of-life
Open WindowsFormsApp1.csproj in Visual Studio.

Press F5 to build and run the application.

📁 Project Structure
Form1.cs – Contains the main UI logic and the rendering engine for the grid.

Program.cs – The entry point of the application.

WindowsFormsApp1.csproj – The project configuration file (updated for modern .NET).

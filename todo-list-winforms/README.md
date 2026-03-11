# ToDo List (WinForms)

![C#](https://img.shields.io/badge/language-C%23-blue)
![.NET](https://img.shields.io/badge/framework-.NET%20Framework-purple)
![UI](https://img.shields.io/badge/UI-Windows%20Forms-orange)
![Status](https://img.shields.io/badge/status-learning-green)

Simple Windows Forms application for managing tasks.

## Demo

![ToDoList demo](demo.gif)

```
+---------------------+
| Form1 UI |
| ListView, inputs |
+----------+----------+
|
| BindingSource
|
+----------v----------+
| BindingList |
| <ToDoEntry> |
+----------+----------+
|
|
+----------v----------+
| ToDoEntry |
| title |
| due date |
| description |
+----------+----------+
|
|
+----------v----------+
| JSON file |
| save / load |
+---------------------+
```

## Running the application

1. Download or clone the repository.
2. Open `ToDoList.sln` in Visual Studio.
3. Build the solution.
4. Start the application.

## Author

Krystian Marciniak
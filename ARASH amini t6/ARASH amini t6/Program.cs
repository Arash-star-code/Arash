using System;
using System.IO;
using System.Collections.Generic;

class Student
{
    public string Id;
    public string Name;
    public int Age;
}

class Program
{
    static string filePath = "UNI.txt";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Add student");
            Console.WriteLine("2. Show students");
            Console.WriteLine("3. Delete student");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    ShowStudents();
                    break;
                case "3":
                    DeleteStudent();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    // 1️⃣ Add student
    static void AddStudent()
    {
        Student s = new Student();

        Console.Write("Enter Student ID: ");
        s.Id = Console.ReadLine();

        Console.Write("Enter Name: ");
        s.Name = Console.ReadLine();

        Console.Write("Enter Age: ");
        s.Age = int.Parse(Console.ReadLine());

        string line = $"{s.Id},{s.Name},{s.Age}";
        File.AppendAllText(filePath, line + Environment.NewLine);

        Console.WriteLine("Student added successfully.");
    }

    // 2️⃣ Show students
    static void ShowStudents()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("No data found.");
            return;
        }

        string[] lines = File.ReadAllLines(filePath);

        if (lines.Length == 0)
        {
            Console.WriteLine("No students to display.");
            return;
        }

        foreach (string line in lines)
        {
            string[] data = line.Split(',');
            Console.WriteLine($"ID: {data[0]} | Name: {data[1]} | Age: {data[2]}");
        }
    }

    // 3️⃣ Delete student
    static void DeleteStudent()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        Console.Write("Enter Student ID to delete: ");
        string idToDelete = Console.ReadLine();

        List<string> newLines = new List<string>();
        bool found = false;

        foreach (string line in File.ReadAllLines(filePath))
        {
            if (!line.StartsWith(idToDelete + ","))
            {
                newLines.Add(line);
            }
            else
            {
                found = true;
            }
        }

        File.WriteAllLines(filePath, newLines);

        if (found)
            Console.WriteLine("Student deleted successfully.");
        else
            Console.WriteLine("Student not found.");
    }
}

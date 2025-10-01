
using Assignment_01_OOP;
using Demo;
using System;
using System.ComponentModel;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        string input;

        //Create an enum called "WeekDays" with the days of the week (Monday to Sunday) 
        //    as its members. Then, write a C# program that prints out all the days of the week using this enum.

        Console.WriteLine("Days of the week:");
        foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
        {
            Console.WriteLine(day);
        }


        Console.WriteLine("====================================================================");
        //////////////////////////////////////////////////////////////////////////////////////////////

        //Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects 
        //and populate it with data.Then, write a C# program to display the details of all the persons in the array.

        Person[] people = new Person[3];

        people[0].Name = "Ali"; people[0].Age = 25;
        people[1].Name = "Sara"; people[1].Age = 30;
        people[2].Name = "Omar"; people[2].Age = 28;

        foreach (var p in people)
            Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");


        // Create an enum called "Seas on" with the four seasons(Spring, Summer, Autumn, Winter) 
        // as its members.Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
        // Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

        Console.WriteLine("====================================================================");
        //////////////////////////////////////////////////////////////////////////////////////////////

        Console.Write("Enter Season: ");
        input = Console.ReadLine();

        if (Enum.TryParse(input, true, out Season season))
        {
            string result = season switch
            {
                Season.Spring => "March to May",
                Season.Summer => "June to August",
                Season.Autumn => "September to November",
                Season.Winter => "December to February",
                _ => "Invalid season"
            };

            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }

        Console.WriteLine("====================================================================");
        //////////////////////////////////////////////////////////////////////////////////////////////

        // Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum.

        User user = new User();
        user.Id = 1;
        user.Permissions = Permission.Read | Permission.Write;

        Console.WriteLine(user.Permissions);

        // Add Execute
        user.Permissions |= Permission.Execute;
        Console.WriteLine("After add Execute: " + user.Permissions);

        // Remove Write
        user.Permissions &= ~Permission.Write;
        Console.WriteLine("After remove Write: " + user.Permissions);

        // Check Read
        if ((user.Permissions & Permission.Read) == Permission.Read)
            Console.WriteLine("User has Read");
        else
            Console.WriteLine("No Read");

        Console.WriteLine("====================================================================");
        //////////////////////////////////////////////////////////////////////////////////////////////

        //Create an enum called "Colors" with the basic colors(Red, Green, Blue)
        //as its members.Write a C# program that takes a color name
        //as input from the user and displays a message indicating whether the input color is a primary color or not.

        Console.Write("Enter Color: ");
        input = Console.ReadLine();

        if (Enum.TryParse(input, true, out Colors color))
        {
            if (color == Colors.Red || color == Colors.Green || color == Colors.Blue)
                Console.WriteLine($"{color} is a Primary Color");
            else
                Console.WriteLine($"{color} is NOT a Primary Color");
        }
        else
        {
            Console.WriteLine("Invalid color");
        }

        Console.WriteLine("====================================================================");
        //////////////////////////////////////////////////////////////////////////////////////////////
        
        // Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points 
        // as input from the user and calculates the distance between them.


        Point p1 = new Point();
        Point p2 = new Point();
        Console.Write("Enter Point 1 (x y): ");
            
        string[] parts = Console.ReadLine().Split(' ');

        p1.X = int.Parse(parts[0]);
        p1.Y = int.Parse(parts[1]);
        Console.Write("Enter Point 2 (x y): ");
        
        parts = Console.ReadLine().Split(' ');
        p2.X = int.Parse(parts[0]);
        p2.Y = int.Parse(parts[1]);
        double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        Console.WriteLine($"Distance between ({p1.X},{p1.Y}) and ({p2.X},{p2.Y}) is {distance}");

        
        Console.WriteLine("====================================================================");
        //////////////////////////////////////////////////////////////////////////////////////////////

        //Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons 
        //as input from the user and displays the name and age of the oldest person.

        Person[] persons = new Person[3];
        for (int i = 0; i < persons.Length; i++)
        {
            Console.Write($"Enter Name of Person {i + 1}: ");
            persons[i].Name = Console.ReadLine();
            Console.Write($"Enter Age of Person {i + 1}: ");
            persons[i].Age = int.Parse(Console.ReadLine());
        }

        Person oldest = persons[0];
        for (int i = 1; i < persons.Length; i++)
        {
            if (persons[i].Age > oldest.Age)
                oldest = persons[i];
        }
        Console.WriteLine($"Oldest Person is {oldest.Name} with Age {oldest.Age}")

    }
}

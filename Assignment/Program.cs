using Assignment.Structs;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //Question (1)
            //    Define a struct "Person" with properties "Name" and "Age".
            //    Create an array of three "Person" objects and populate it with data.Then,
            //    write a C# program to display the details of all the persons in the array.
            Person[] people = 
            {
            new Person("Ahmed", 22),
            new Person("Omar", 25),
            new Person("Ali", 23)
            };
          
            Console.WriteLine("Persons Details:");
            foreach (Person person in people)
            {
                person.Print();
            }

            // Question (2)
            //Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            //Write a C# program that takes two points as input from the user and calculates the distance between them.
            Console.WriteLine("Enter the first point:");
            Console.Write("X1: ");
            double x1, y1, x2, y2;
            while (!double.TryParse(Console.ReadLine(), out x1))
            {
                Console.Write("Invalid input. Please enter a number for X1: ");
            }
            Console.Write("Y1: ");
            while (!double.TryParse(Console.ReadLine(), out y1))
            {
                Console.Write("Invalid input. Please enter a number for y1: ");
            }

            Console.WriteLine("Enter the second point:");
            Console.Write("X2: ");
            while (!double.TryParse(Console.ReadLine(), out x2))
            {
                Console.Write("Invalid input. Please enter a number for X2: ");
            }
            Console.Write("Y2: ");
            while (!double.TryParse(Console.ReadLine(), out y2))
            {
                Console.Write("Invalid input. Please enter a number for y2: ");
            }

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);

            double distance = Point.Distance(p1, p2);
            Console.WriteLine($"Distance between the two points: {distance}");

        }
}
}

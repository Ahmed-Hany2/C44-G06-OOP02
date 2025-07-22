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

            // Question (3)
            //Create a struct called "Person" with properties "Name" and "Age".
            //Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            Person[] peoples2 = new Person[3];

          
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter details for person #{i + 1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                int age;
                Console.Write("Age: ");
                while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
                {
                    Console.Write("Invalid input. Enter a valid age: ");
                }
                people[i] = new Person(name, age);
            }
            Person oldest = people[0];

            for (int i = 1; i < people.Length; i++)
            {
                if (people[i].Age > oldest.Age)
                {
                    oldest = people[i];
                }
            }
            Console.WriteLine($"\nThe oldest person is {oldest.Name}, Age: {oldest.Age}");


        }
}
}

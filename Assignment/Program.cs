using Assignment.structs;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define a struct "Person" with properties "Name" and "Age". 
            //Create an array of three "Person" objects and populate it with data.Then, 
            //write a C# program to display the details of all the persons in the array.
            Person[] people =
            {
                new Person("Ahmed", 22),
                new Person("Ali", 23),
                new Person("Omar", 25)
            };
            
            Console.WriteLine("Persons Details:");
            foreach (Person person in people)
            {
                person.Print();
            }



        }
    }
}

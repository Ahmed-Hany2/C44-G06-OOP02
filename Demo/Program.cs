using System.Drawing;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct Example 02
            Point p1 = new Point(3, 4);
            Console.WriteLine($"Point 1: ({p1.X}, {p1.Y})");
            Point p2 = new Point(6, 8);
            Console.WriteLine($"Point 2: ({p2.X}, {p2.Y})");

            p2 = p1;

            Console.WriteLine($"======================= After =====================");

            Console.WriteLine($"Point 1: ({p1.X}, {p1.Y})");
            Console.WriteLine($"Point 2: ({p2.X}, {p2.Y})");

            p1.X = 100;
            p1.Y = 200;

            Console.WriteLine($"======================= After Changing =====================");
            Console.WriteLine($"Point 1: ({p1.X}, {p1.Y})");
            Console.WriteLine($"Point 2: ({p2.X}, {p2.Y})");
            #endregion

            #region Overview Encapsulation
            BankAccount account = new BankAccount();
            account.Deposit(1000);
            Console.WriteLine($"Account Balance: {account.GetBalance()}");
            #endregion


        }
    }
}

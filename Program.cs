using System.ComponentModel.Design;

namespace MiniCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välja siffra nummer 1: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Välja siffra nummer 2");
            int y = int.Parse(Console.ReadLine());


            int choice = Menu();

            switch (choice)
            {
                case 1: Console.WriteLine(Add(x, y)); break;
                case 2: Console.WriteLine(Subtract(x, y)); break;
                case 3: Console.WriteLine(Multiply(x, y)); break;
                case 4: Console.WriteLine(Divide(x, y)); break;
                default: Console.WriteLine("Ogiltigt val"); break;
                    break;
            }
        }

        static int Menu()
        {

            Console.WriteLine("Välj en operation: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            
            string input = Console.ReadLine();

            return int.Parse(input);

        }
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Divide(int a, int b)
        {
            return (double)a / b;
        }
    }
}

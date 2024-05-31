using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Question_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Enter first number");
            double num1 = Convert.ToDouble(Console.ReadLine());  

            Console.WriteLine("Enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter 1 to add\n2 to subtract\n3 to multiply\n4 to divide");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Pointer pointer = new Pointer(math.add);
                    Console.WriteLine($"Addition : {pointer(num1, num2)}");
                    break;

                case 2:
                    pointer = new Pointer(math.subtract);
                    Console.WriteLine($"Sub : {pointer(num1, num2)}");
                    break;
                case 3:
                    pointer = new Pointer(math.multiply);
                    Console.WriteLine($"Multiplication : {pointer(num1, num2)}");
                    break;
                case 4:
                    pointer = new Pointer(math.divide);
                    Console.WriteLine($"Division : {pointer}");
                    break;
            }
            Console.ReadLine();
        }
    }
    public delegate double Pointer(double x, double y);
    public class Math
    {
        public Math() { }

        public double add(double a, double b) { return a + b; }

        public double subtract(double a, double b) { return a - b; }

        public double multiply(double a, double b) { return a * b; }

        public double divide(double a, double b) { return a / b; }

    }
}

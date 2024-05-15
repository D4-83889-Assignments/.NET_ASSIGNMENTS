namespace Ques_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Argument1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Argument2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operand: ");
            string op = Console.ReadLine();



            switch (op)
            {
                case "+":
                    Console.WriteLine("Sum is " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("Difference is " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("Product is " + (num1 * num2));
                    break;

                case "/":
                    if (num1 != 0)
                    {
                        Console.WriteLine("Quotient is " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("Can't divide by zero");
                    }
                    break;
                default:
                    Console.WriteLine("Wrong Choice Entered");
                    break;
            }
            Console.WriteLine("Program Exited");
        }
    }
}

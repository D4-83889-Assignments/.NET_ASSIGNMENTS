namespace Ques_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1;
            int choice;
            int num2;
            string op;
            do
            {
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("0.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    continue;
                }
                Console.WriteLine("Enter Arg1: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Arg2: ");
                num2 = Convert.ToInt32(Console.ReadLine());
              

                switch (choice) {
                    case 1:
                        Console.WriteLine("Sum is "+(num1+num2));
                        break;
                    case 2:
                        Console.WriteLine("Difference is " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Product is " + (num1 * num2));
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            Console.WriteLine("Quotient is " + (num1 / num2));
                        }
                        else
                        {
                            Console.WriteLine("Can not divide by zero");
                        }

                        break;
                   
                        
                    default:
                        Console.WriteLine("Wrong Option Entered");
                        break;
                }


            } while (choice != 0);
            Console.WriteLine("Thanks for using my Application!");
        }
    }
}

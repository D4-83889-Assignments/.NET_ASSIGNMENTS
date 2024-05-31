using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.Accept();
            int choice = menu();

            while (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        company.AddEmployee();
                        break;
                    case 2:
                        Console.WriteLine("Enter id of the employee");
                        company.findEmployee(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 3:
                        company.DisplayEmployees();
                        break;
                    case 4:
                        company.Print();
                        break;
                    case 5:
                        Console.WriteLine("Enter filename to serialize employees");
                        string serializeFileName = Console.ReadLine();
                        company.SerializeEmployees(serializeFileName);
                        break;
                    case 6:
                        Console.WriteLine("Enter filename to deserialize employees");
                        string deserializeFileName = Console.ReadLine();
                        company.DeserializeEmployees(deserializeFileName);
                        break;
                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
                choice = menu();
            }
            Console.WriteLine("Program end");
            Console.ReadLine();
        }

        public static int menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2. Find an employee");
            Console.WriteLine("3. Display all employees");
            Console.WriteLine("4. Display company info");
            Console.WriteLine("5. Serialize employees");
            Console.WriteLine("6. Deserialize employees");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}

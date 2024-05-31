using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EmployeeClassLib;

namespace Question_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.Accept();
            int choice = menu();

            while(choice != 0) {
                switch(choice)
                {
                    case 1:
                        company.AddEmployee();
                        break;
                    case 2:
                        Console.WriteLine("Enter id of the employee to be reomved");
                        company.removeEmployee(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("Enter id of the employee");
                        company.findEmployee(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 4:
                        company.DisplayEmployees();
                        break;
                    case 5:
                        company.Print();
                        break;
                     default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
                choice= menu();
            }
            Console.WriteLine("Program end");
            Console.ReadLine();
        }
        public static int menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1.  Add employee");
            Console.WriteLine("2. Remove an employee");
            Console.WriteLine("3. Find an employee");
            Console.WriteLine("4. Display all employees");
            Console.WriteLine("5. Display company info");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}

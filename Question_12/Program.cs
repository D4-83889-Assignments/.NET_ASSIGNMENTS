using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.Accept();
            Console.WriteLine("Enter number of employees");
            int empCount = Convert.ToInt32(Console.ReadLine()); 
            for(int i = 0; i < empCount; i++)
            {
                company.AddEmployee();
            }
            company.Print();
            company.DisplayEmployees();
            Console.ReadLine();
        }
    }
}

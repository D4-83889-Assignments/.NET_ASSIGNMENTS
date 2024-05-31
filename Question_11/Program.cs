using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WageEmp wageEmp = new WageEmp();
            wageEmp.Accept();
            wageEmp.Print();
            Console.ReadLine();
        }
    }
}

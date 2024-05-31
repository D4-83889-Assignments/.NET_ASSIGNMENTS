using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Supervisor supervisor = new Supervisor();
            supervisor.Accept();
            supervisor.Print(); 
            Console.ReadLine();
        }
    }
}

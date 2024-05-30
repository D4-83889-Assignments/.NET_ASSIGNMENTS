using Ques_4;
using System.Runtime.CompilerServices;
using System.Transactions;
using System;

namespace Ques_4
{ 
    struct Student {
        private string name =""; 
        private int age = 0;
        private int std = 0;
        private char div = 'A';
        private double marks = 0.0;
        private bool gender = false;

        public Student()
        {
            _div = 'A';
            _age = 0;
            _std = 0;
            _marks = 0.0;
            _name = "";
            _gender = false;
        }
        public Student(string name, char div, int age, int std, double marks, bool gender)
        {
            _name = name;
            _div = div;
            _age = age;
            _std = std;
            _marks = marks;
            _gender = gender;
        }

        public bool _gender
        {
            get { return gender; }
            set { gender = value; }
        }




        public double _marks
        {
            get { return marks; }
            set { marks = value; }
        }


        public char _div
        {
            get { return div; }
            set { div = value; }
        }


        public int _std
        {
            get { return std; }
            set { std = value; }
        }


        public int _age
        {
            get { return age; }
            set { age = value; }
        }


      


        public string _name
        {
            get { return name; }
            set { name = value; }
        }

       



        public void accepDetails() {
            Console.WriteLine("Enter Name");
            _name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            _age = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter Gender");
            _gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter Marks");
            _marks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Div");
            _div = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Std");
            _std = Convert.ToInt32(Console.ReadLine());


        }

        public void printDetails() {

            Console.WriteLine("Name: "+_name);
            Console.WriteLine("Age: "+_age);
            if (_gender == true)
            {
                Console.WriteLine("Gender: Male");
            }
            else
            {
                Console.WriteLine("Gender: Female");
            }
            Console.WriteLine("Marks: "+_marks);
            Console.WriteLine("Div: "+_div);
            Console.WriteLine("Std: "+_std);

        }

    }

    };


    internal class Program
    {
        static void Main(string[] args)
        {
        Student s = new Student();
        Console.WriteLine("Printing Default Values of Student object: ");
        s.printDetails();
        s.accepDetails();
        s.printDetails();
        }
    }

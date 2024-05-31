﻿using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
using System.Collections.Generic;

namespace EmployeeClassLib
{
    [Serializable]
    public class Person
    {
        protected string name;
        protected bool gender;
        protected DateTime birth;
        protected string address;

        public Person() { }

        public Person(string name, bool gender, DateTime birth, string address)
        {
            this.name = name;
            this.gender = gender;
            this.birth = birth;
            this.address = address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public DateTime Birth
        {
            get { return birth; }
            set { birth = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - birth.Year;
                if (birth.Date > today.AddYears(-age)) age--;
                return age;
            }
        }

        public virtual void Accept()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Gender (true for Male, false for Female): ");
            Gender = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter Birth Date (YYYY-MM-DD): ");
            Birth = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Address: ");
            Address = Console.ReadLine();
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gender: {(Gender ? "Male" : "Female")}");
            Console.WriteLine($"Birth Date: {Birth:yyyy-MM-dd}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Age: {Age}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Gender: {(Gender ? "Male" : "Female")}, Birth Date: {Birth:yyyy-MM-dd}, Address: {Address}, Age: {Age}";
        }
    }

    [Serializable]
    public class Employee : Person
    {
        private static int count = 0;
        private int id;
        private double salary;
        private string designation;
        private DepartmentType dept;

        public Employee() : base()
        {
            id = ++count;
        }

        public Employee(string name, bool gender, DateTime birth, string address, double salary, string designation, DepartmentType dept)
            : base(name, gender, birth, address)
        {
            id = ++count;
            this.salary = salary;
            this.designation = designation;
            this.dept = dept;
        }

        public int Id => id;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public DepartmentType Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        public override void Accept()
        {
            base.Accept();

            Console.Write("Enter Salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Designation: ");
            Designation = Console.ReadLine();

            Console.Write("Enter Department (0 for IT, 1 for HR, 2 for Finance): ");
            Dept = (DepartmentType)Convert.ToInt32(Console.ReadLine());
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Designation: {Designation}");
            Console.WriteLine($"Department: {Dept}");
        }

        public override string ToString()
        {
            return base.ToString() + $", ID: {Id}, Salary: {Salary}, Designation: {Designation}, Department: {Dept}";
        }
    }

    [Serializable]
    public enum DepartmentType
    {
        IT,
        HR,
        Finance
    }

    [Serializable]
    public class Company
    {
        public string Name { get; set; }
        public double SalaryExpense { get; set; }

        private LinkedList<Employee> empList = new LinkedList<Employee>();

        public Company() { }

        public Company(string name, double salaryExpense)
        {
            Name = name;
            SalaryExpense = salaryExpense;
        }

        public void Accept()
        {
            Console.WriteLine("Enter name of the company");
            Name = Console.ReadLine();

            Console.WriteLine("Enter monthly salary expense");
            SalaryExpense = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Company information registered");
        }

        public void Print()
        {
            Console.WriteLine($"Company Name: {Name}");
            Console.WriteLine($"Monthly Salary Expense: {SalaryExpense}");
        }

        public void AddEmployee()
        {
            Employee emp = new Employee();
            emp.Accept();
            empList.AddFirst(emp);
            Console.WriteLine("Employee added");
        }

        public void DisplayEmployees()
        {
            foreach (Employee emp in empList)
            {
                emp.Print();
            }
        }

        public void findEmployee(int id)
        {
            foreach (Employee emp in empList)
            {
                if (emp.Id == id)
                {
                    emp.Print();
                }
            }
        }

        public void removeEmployee(int id)
        {
            Employee employeeToRemove = null;
            foreach (var emp in empList)
            {
                if (emp.Id == id)
                {
                    employeeToRemove = emp;
                    break;
                }
            }

            if (employeeToRemove != null)
            {
                empList.Remove(employeeToRemove);
                Console.WriteLine("Employee removed");
            }
            else
            {
                Console.WriteLine("Employee not found");
            }
        }

        public void SerializeEmployees(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, empList);
                Console.WriteLine("Employees serialized");
            }
        }

        public void DeserializeEmployees(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    empList = (LinkedList<Employee>)formatter.Deserialize(fs);
                    Console.WriteLine("Employees deserialized");
                }
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }

    [Serializable]
    public class Manager : Employee
    {
        public double Bonus { get; set; }

        public Manager() : base() { }

        public Manager(string name, bool gender, DateTime birth, string address, double salary, string designation, DepartmentType dept, double bonus)
            : base(name, gender, birth, address, salary, designation, dept)
        {
            Bonus = bonus;
        }

        public override void Accept()
        {
            base.Accept();
            Console.Write("Enter bonus: ");
            Bonus = Convert.ToDouble(Console.ReadLine());
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Bonus: {Bonus}");
        }
    }

    [Serializable]
    public class Supervisor : Employee
    {
        public int Subordinates { get; set; }

        public Supervisor() : base() { }

        public Supervisor(string name, bool gender, DateTime birth, string address, double salary, string designation, DepartmentType dept, int subordinates)
            : base(name, gender, birth, address, salary, designation, dept)
        {
            Subordinates = subordinates;
        }

        public override void Accept()
        {
            base.Accept();
            Console.Write("Enter number of subordinates: ");
            Subordinates = Convert.ToInt32(Console.ReadLine());
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Subordinates: {Subordinates}");
        }
    }

    [Serializable]
    public class WageEmp : Employee
    {
        public int Hours { get; set; }
        public int Rate { get; set; }

        public WageEmp() : base() { }

        public WageEmp(string name, bool gender, DateTime birth, string address, double salary, string designation, DepartmentType dept, int hours, int rate)
            : base(name, gender, birth, address, salary, designation, dept)
        {
            Hours = hours;
            Rate = rate;
        }

        public override void Accept()
        {
            base.Accept();
            Console.Write("Enter number of hours: ");
            Hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter wage per hour: ");
            Rate = Convert.ToInt32(Console.ReadLine());
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Hours: {Hours}");
            Console.WriteLine($"Rate: {Rate}");
        }
    }
}
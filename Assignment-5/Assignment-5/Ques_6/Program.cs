
namespace Ques_7
{

    class Date
    {



        private int day;
        private int month;
        private int year;

        public Date()
        {

        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }


        public int _year
        {
            get { return year; }
            set { year = value; }
        }






        public int _month
        {
            get { return month; }
            set { month = value; }
        }



        public int _day
        {
            get { return day; }
            set { day = value; }
        }


        public void acceptDate()
        {
            Console.WriteLine("Enter day");
            day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter month");
            month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter year");
            year = Convert.ToInt32(Console.ReadLine());


        }

        public void displayDate()
        {
            Console.WriteLine("Day/Month/Year: " + day + "/" + month + "/" + year);
        }

        public bool isValidDate()
        {
            if (day <= 31 && day >= 1)
            {
                if (month <= 12 && month >= 1)
                {
                    if (year <= 2400 && year >= 1900)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override string ToString()
        {
            return $"Day/Month/Year: {day}/{month}/{year}";
        }

        public static int operator -(Date d1, Date d2)
        {
            return Math.Abs(d1.year - d2.year);
        }


    }

    class Person
    {
        private string name;
        private bool gender;
        Date birth;
        string address;
        int age;
        public Person()
        {
            name = "";
            gender = false;
            birth = new Date(1, 1, 2000);
            address = "Pune";
            age = 0;
        }

        public Person(string name, bool gender, Date birth, string address, int age)
        {
            this.name = name;
            this.gender = gender;
            this.birth = birth;
            this.address = address;
            this.age = age;
        }

        public string getName()
        {
            return name;
        }

        public string getAddress()
        {
            return address;
        }

        public int getAge()
        {
            return age;
        }
        public Date getBirth()
        {
            return birth;
        }

        public bool getGender()
        {
            return gender;
        }

        public void acceptPerson()
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter address");
            address = Console.ReadLine();
            Console.WriteLine("Enter dob");
            birth.acceptDate();
            Console.WriteLine("Enter gender");
            gender = Convert.ToBoolean(Console.ReadLine());
            calAge(birth);

        }

        private void calAge(Date birth)
        {
            int today = DateTime.Today.Year;
            age = today - birth._year;
        }

        public void printPerson()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            if (gender)
            {
                Console.WriteLine("Gender: Male");
            }
            else
            {
                Console.WriteLine("Gender: Female");
            }

            Console.WriteLine("Birth: " + birth);
            Console.WriteLine("Age: " + age);
        }

        public override string ToString()
        {
            return $"Name: {name}, Address: {address}, Gender: {(gender ? "Male" : "Female")}, Birth: {birth}, Age: {age}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.acceptPerson();
            p.printPerson();
            Console.WriteLine(p.ToString());

        }
    }
}

namespace Assignment13
{
    public class Date
    {
        private int _day;
        private int _month;
        private int _year;

        public Date() : this(00, 00, 0000)
        {
        }

        public void AcceptDate()
        {
            Console.WriteLine("Enter the Day -");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Month -");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year -");
            year = Convert.ToInt32(Console.ReadLine());

        }

        public void PrintData()
        {
            Console.WriteLine(day + "-" + month + "-" + year);
        }
        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
        public bool IsValid()
        {
            if (year < 1 || month < 1 || month > 12 || day < 1)
            {
                return false;
            }

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Adjust for leap year
            if (IsLeapYear(year))
            {
                daysInMonth[1] = 29;
            }

            if (day > daysInMonth[month - 1])
            {
                return false;
            }

            return true;
        }


        public Date(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        public int year
        {
            get { return _year; }
            set { _year = value; }
        }


        public int month
        {
            get { return _month; }
            set { _month = value; }
        }

        public int day
        {
            get { return _day; }
            set { _day = value; }
        }

        public override string ToString()
        {
            return day + "-" + month + "-" + year;
        }

        public static int DifferenceInYears(Date date1, Date date2)
        {
            //Console.WriteLine("in differ function");
            return Math.Abs(date1.year - date2.year);
        }
        //private int calculatenumberdate(date day)
        //{
        //    return 
        //}
        public static int operator -(Date date1, Date date2)
        {
            return DifferenceInYears(date1, date2);
        }
    }

    public class Person
    {
        private string _name;
        private bool _gender;
        private Date _birth = new Date();
        private string _address;

        public Person()
        {
        }

        public Person(string name, bool gender, Date birth, string address)
        {
            _name = name;
            _gender = gender;
            _birth = birth;
            _address = address;
        }

        public string address
        {
            get { return _address; }
            set { _address = value; }
        }


        public Date birth
        {
            get { return _birth; }
            set { _birth = value; }
        }


        public bool gender
        {
            get { return _gender; }
            set { _gender = value; }
        }


        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Accept()
        {
            Console.WriteLine("Enter the name of person");
            name = Console.ReadLine();
        repeat:
            Console.WriteLine("Enter gende M/F");
            string genderString = Console.ReadLine();

            if (genderString == "M")
            {
                gender = true;
            }
            else if (genderString == "F")
            {
                gender = false;
            }
            else
            {
                Console.WriteLine("invalid input");
                goto repeat;
            }
            Console.WriteLine("Enter your Birth date-");
            birth.AcceptDate();
            Console.WriteLine("Enter Person Address");
            address = Console.ReadLine();

        }

        public virtual void Print()
        {
            Console.WriteLine("Name-" + name);
            Console.WriteLine(gender ? "Gender-Male" : "Gender-Female");
            Console.Write("Birth Date-");
            birth.PrintData();

            Console.WriteLine("Age-" + CalculateAge());
            Console.WriteLine("Address-" + address);
        }


        public int CalculateAge()
        {
            Date today = new Date();
            DateTime tod = DateTime.Now;
            today.day = tod.Day;
            today.month = tod.Month;
            today.year = tod.Year;
            today.ToString();
            int age = Date.DifferenceInYears(birth, today);
            return age;

        }


        public virtual string ToString()
        {
            return "Name-" + name + (gender ? "Gender-Male" : "Gender-Female") + "Birth Date-" + birth.ToString() + "Address-" + address;
        }
    }

    public enum DepartmentType
    {
        Accounts,
        IT,
        Maintenance,
        Sales
    }
    public class Employee : Person
    {
        private int _id = Count++;
        private double _salary;
        private string _designation = "Emp";
        private DepartmentType _dept;
        private static int Count = 0;

        public Employee()
        {
        }




        public Employee(string name, bool gender, Date birth, string address, double salary, string designation, DepartmentType dept) : base(name, gender, birth, address)
        {
            _salary = salary;
            _designation = designation;
            _dept = dept;
        }

        public virtual void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter salary of the employee");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("choose your department");
            Console.WriteLine("0. Accounts");
            Console.WriteLine("1. IT");
            Console.WriteLine("2. Maintenance");
            Console.WriteLine("3. Sales");
            int deptno = 0;
            deptno = Convert.ToInt32(Console.ReadLine());
            if (deptno < 4 && deptno >= 0)
            {
                dept = (DepartmentType)deptno;
            }
        }

        protected void PersonAccept()
        {
            base.Accept();
        }

        public virtual void Print()
        {
            base.Print();
            Console.WriteLine("ID-" + id);
            Console.WriteLine("Salary-" + salary);
            Console.WriteLine("Designation-" + designation);
            Console.WriteLine("Department-" + dept);
        }

        public DepartmentType dept
        {
            get { return _dept; }
            set { _dept = value; }
        }

        public string designation
        {
            get { return _designation; }
            set { _designation = value; }
        }

        public double salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public int id
        {
            get { return _id; }
        }

        public override string ToString()
        {
            return base.ToString() + "Id-" + id + "Salary-" + designation + "Department" + dept + "Designation" + designation;

        }

    }

   public class Manager : Employee
    {
        private double _bonus;

        public Manager()
        {
        }

        public Manager(string name, bool gender, Date birth, string address, double salary, string designation, DepartmentType dept, double bonus) : base(name, gender, birth, address, salary, "Manager", dept)
        {
            this.bonus = bonus;
        }

        public override void Accept()
        {

            base.Accept();
            base.designation = "Manager";
            Console.WriteLine("Bonus Of Employee");
            bonus = Convert.ToDouble(Console.ReadLine());
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Bonus-" + bonus);
        }

        public double bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "Bonus-" + bonus;
        }
    }

    public class Supervisore : Employee
    {
        private int _subbordinates;

        public Supervisore()
        {
        }

        public Supervisore(string name, bool gender, Date birth, string address, double salary, string designation, DepartmentType dept, int subbordinates) : base(name, gender, birth, address, salary, "Manager", dept)
        {
            this.subbordinates = subbordinates;
        }

        public override void Accept()
        {

            base.Accept();
            base.designation = "Supervisor";
            Console.WriteLine("Enter the subbordinates of Employee");
            subbordinates = Convert.ToInt32(Console.ReadLine());
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("subbordinates-" + subbordinates);
        }

        public int subbordinates
        {
            get { return _subbordinates; }
            set { _subbordinates = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "subbordinates-" + _subbordinates;
        }
    }

    public class WageEmp : Employee
    {
        private int _Hours;
        private int _Rate;

        public int Rate
        {
            get { return _Rate; }
            set { _Rate = value; }
        }


        public int Hours
        {
            get { return _Hours; }
            set { _Hours = value; }
        }

        public WageEmp()
        {
        }

        public WageEmp(string name, bool gender, Date birth, string address, double salary, string designation, DepartmentType dept, int hours, int rate) : base(name, gender, birth, address, salary, "Wage", dept)
        {
            Hours = hours;
            Rate = rate;
        }

        public override void Accept()
        {

            base.Accept();
            base.designation = "Wage";
            Console.WriteLine("Enter the Working Hours of Wage");
            Hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rate per hour for wage");
            Rate = Convert.ToInt32(Console.ReadLine());

        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Working Hours-" + Hours);
            Console.WriteLine("Rate Per hour" + Rate);
        }



        public override string ToString()
        {
            return base.ToString() + "Hours-" + Hours + "Rate-" + Rate;
        }
    }

    public class Company
    {
        private string _Name;
        private string _Address;
        private LinkedList<Employee> _EmployeeList;
        private double _SalaryExpense;

        public Company()
        {
            EmployeeList = new LinkedList<Employee>();
        }

        public Company(string name, string address, LinkedList<Employee> employeeList, double salaryExpense)
        {
            _Name = name;
            _Address = address;
            _EmployeeList = employeeList;
            _SalaryExpense = salaryExpense;
        }

        public void Accept()
        {
            Console.WriteLine("Enter the Name of Company");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the addresss of Company");
            Address = Console.ReadLine();
        }
        public void AddEmployee(Employee employee)
        {
            EmployeeList.AddLast(employee);
        }
        public double CalculateSalaryExpense()
        {
            double salaryExpense = 0;
            foreach (Employee emp in EmployeeList)
            {
                salaryExpense = salaryExpense + emp.salary;
            }
            return salaryExpense;
        }

        public bool RemoveEmployee(int id)
        {
            bool flag = false;
            //  Employee emp1;
            foreach (Employee emp in EmployeeList)
            {
                if (emp.id == id)
                {
                    flag = true;
                    //emp1 = emp;
                    EmployeeList.Remove(emp);

                }
            }
            // EmployeeList.Remove(id);
            return flag;
        }

        public LinkedListNode<Employee> FindEmployee(int id)
        {
            LinkedListNode<Employee> node = null;
            foreach (Employee emp in EmployeeList)
            {
                if (emp.id == id)
                {
                    node = new LinkedListNode<Employee>(emp);
                    break;
                }
            }

            return node;
        }

        public void PrintEmployees()
        {
            foreach (Employee emp in EmployeeList)
            {
                emp.Print();
            }
        }
        public void Print()
        {
            Console.WriteLine("Company Name-" + Name);
            Console.WriteLine("Company Address-" + Address);
        }
        public double SalaryExpense
        {
            get { return _SalaryExpense; }
            set { _SalaryExpense = value; }
        }

        public LinkedList<Employee> EmployeeList
        {
            get { return _EmployeeList; }
            set { _EmployeeList = value; }
        }

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public override string ToString()
        {
            return "Company Name-" + Name + "Company Address-" + Address;
        }
    }
}

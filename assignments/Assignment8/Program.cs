using Assignment6;
using Assignment7;
namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Employee employee = new Employee();
            employee.Accept();
            employee.Print();
        }
    }
   public enum DepartmentType
    {
        Accounts,
        IT,
        Maintenance,
        Sales
    }
    public class Employee :Person
    {
        private int _id =Count++;
        private double _salary;
        private string _designation = "Emp";
        private DepartmentType _dept;
        private static int Count = 0;

        public Employee()
        {
        }




        public Employee(string name, bool gender, Date birth, string address, double salary, string designation, DepartmentType dept):base(name,gender,birth,address) 
        {
            _salary = salary;
            _designation = designation;
            _dept = dept;
        }

        public virtual void  Accept()
        {
            base.Accept();
            Console.WriteLine("Enter salary of the employee");
            salary=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("choose your department");
            Console.WriteLine("0. Accounts");
            Console.WriteLine("1. IT");
            Console.WriteLine("2. Maintenance");
            Console.WriteLine("3. Sales");
            int deptno = 0;
             deptno = Convert.ToInt32(Console.ReadLine());
            if(deptno < 4 && deptno>=0)
            {
                dept= (DepartmentType)deptno;
            }
        }

        protected void PersonAccept()
        {
            base.Accept();
        }

        public virtual void  Print()
        {
            base.Print();
            Console.WriteLine("ID-"+id);
            Console.WriteLine("Salary-"+salary);
            Console.WriteLine("Designation-"+designation);
            Console.WriteLine("Department-"+dept);
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
            return base.ToString()+"Id-"+id+"Salary-"+designation+"Department"+dept+"Designation"+designation;

        }

    }
}

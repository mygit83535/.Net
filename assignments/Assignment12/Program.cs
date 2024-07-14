using Assignment8;
using Assignment6;
namespace Assignment12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Company
    {
        private string  _Name;
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
            Console.WriteLine("Company Name-"+Name);
            Console.WriteLine("Company Address-"+Address);
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


        public string  Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public override string ToString()
        {
            return "Company Name-"+Name+"Company Address-"+Address;

        }
    }
}

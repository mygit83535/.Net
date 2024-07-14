using Assignment8;
using Assignment6;
namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WageEmp emp = new WageEmp();
            emp.Accept();
            emp.Print();
        }
    }

    class WageEmp : Employee
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

        public WageEmp(string name, bool gender, Date birth, string address, double salary, string designation, DepartmentType dept, int hours,int rate) : base(name, gender, birth, address, salary, "Wage", dept)
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
            Console.WriteLine("Rate Per hour"+Rate);
        }

      

        public override string ToString()
        {
            return base.ToString() + "Hours-" + Hours+"Rate-"+Rate;
        }
    }
}

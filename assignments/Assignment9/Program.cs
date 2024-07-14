using Assignment6;
using Assignment8;
namespace Assignment9
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Manager manager = new Manager();
            manager.Accept();
            manager.Print();
        }
    }

    class Manager:Employee
    {
        private double _bonus;

        public Manager()
        {
        }

        public Manager(string name, bool gender, Date birth, string address, double salary, string designation, DepartmentType dept,double bonus) :base(name,gender,birth,address,salary,"Manager",dept)
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
            Console.WriteLine("Bonus-"+bonus);
        }

        public double bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "Bonus-"+ bonus;
        }
    }
}

using Assignment8;
using Assignment6;
namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Supervisore supervisore = new Supervisore();
            supervisore.Accept();
            supervisore.Print();
        }
    }

    class Supervisore : Employee
    {
      private int _subbordinates;

        public Supervisore()
        {
        }

        public Supervisore(string name, bool gender, Date birth, string address, double salary, string designation, DepartmentType dept, int subbordinates ) : base(name, gender, birth, address, salary, "Manager", dept)
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
}



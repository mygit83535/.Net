using Assignment6;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Accept();
            p1.Print();
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
            Console.WriteLine ("Enter the name of person");
            name = Console.ReadLine();
        repeat:
            Console.WriteLine ("Enter gende M/F");
            string genderString = Console.ReadLine ();
           
            if(genderString == "M")
            {
                gender = true;
            }
            else if(genderString == "F")
            {
                gender= false;
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

        public void Print()
        {
            Console.WriteLine("Name-"+name);
            Console.WriteLine(gender?"Gender-Male":"Gender-Female");    
            Console.Write("Birth Date-");
            birth.PrintData();
           
            Console.WriteLine("Age-"+CalculateAge());
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
            return "Name-"+name+( gender ? "Gender-Male" : "Gender-Female")+"Birth Date-"+birth.ToString()+"Address-"+address;
        }
    }
}

namespace Assignment4
{

    public struct Student
    {

        private string _name;
        private bool _gender;
        private int _age;
        private int _std;
        private char _div;
        private double _marks;

        public Student() : this("mahesh", true, 50, 12, 'A', 100)
        {
        }

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            _name = name;
            _gender = gender;
            _age = age;
            _std = std;
            _div = div;
            _marks = marks;
        }

        public double marks
        {
            get { return _marks; }
            set { _marks = value; }
        }

        public char div
        {
            get { return _div; }
            set { _div = value; }
        }

        public int std
        {
            get { return _std; }
            set { _std = value; }
        }

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }



        public bool gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter the Student name-");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Student Gender");
            gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter the Student age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Student Std");
            std = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Student division");
            div = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the Student marks");
            marks = Convert.ToDouble(Console.ReadLine());

        }

        public void PrintDetails()
        {
            Console.WriteLine("NAME-"+name);
            if (gender)
                Console.WriteLine("Gender- Male");
            else
                Console.WriteLine("Gender- Female");
            Console.WriteLine("Age-"+age);
            Console.WriteLine("Standard"+std);
            Console.WriteLine("Division-"+div);
            Console.WriteLine("Marks-"+marks);
            Console.WriteLine(Console.ReadLine());

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            student.AcceptDetails();
            student.PrintDetails();



        }


    }


}

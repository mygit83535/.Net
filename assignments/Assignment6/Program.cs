namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date ();
            int choice;
            do
            {
                Console.WriteLine("0. EXIT");
                Console.WriteLine("1. Accept date");
                Console.WriteLine("2. Print date");
                Console.WriteLine("3. Check date valid");
                Console.WriteLine("4. To calculate diiference between two date");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {

                    case 0:
                        Console.WriteLine("THANK TOU.......!!!!!!!!");
                        break;
                    case 1:
                        date.AcceptDate();
                        break;
                    case 2:
                        if (date != null)
                        {
                            date.PrintData();
                        }
                        else
                            Console.WriteLine("First Accept date");
                        break;

                    case 3:

                        if (date != null)
                        {
                            if (date.IsValid())
                            {
                                Console.WriteLine("Date is valid");
                            }
                            else Console.WriteLine("Date is invalid");
                        }
                        else Console.WriteLine("First Accept date");

                        break;
                    case 4:
                        Date date1 = new Date();
                        date1.AcceptDate();
                        Date date2 = new Date();    
                        date2.AcceptDate();
                        Console.WriteLine("Difference is ="+Date.DifferenceInYears(date1, date2));
                        break;
                }

            } while (choice != 0);

        }

        

    }

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
            Console.WriteLine(day + "-" +month + "-" +year);
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
}

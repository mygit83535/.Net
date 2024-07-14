namespace Assign1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kjhkjnjkndjkasndjk
            int num1;
            int num2;
            int choice;
            Console.WriteLine("Enter the num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("0. EXIT");
                Console.WriteLine("1. ADDITION");
                Console.WriteLine("2. SUBSTRACTION");
                Console.WriteLine("3. MULTIPLICATION");
                Console.WriteLine("4. DIVISION");
                Console.WriteLine("ENTER YOUR CHOICE-");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("THANK YOU ");
                        break;
                    case 1:
                        Console.WriteLine("ADDITION =" + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("SUBSTRACTION =" + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("MULTIPLICATION =" + (num1 * num2));

                        break;
                    case 4:

                        Console.WriteLine("DIVISION ="+(num1/num2));
                        break;
                    default:
                        Console.WriteLine("WRONG CHOICE....!!!!");
                        break;
                }
            } while (choice != 0);
        }
    }
}

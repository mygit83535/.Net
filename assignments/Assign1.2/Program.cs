namespace Assign1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Int32.Parse(args[0]);
            int num2 = Int32.Parse(args[1]);
            //sjkdhasjkdkja
            switch (args[2])
            {
                case "+":
                    Console.WriteLine("ADDITION = " + num1 + num2);
                    break;
                case "-":
                   Console.WriteLine("SUBSTRACTION = "+(num1-num2));
                    break;
                case "*":
                    Console.WriteLine("MULTIPLICATION =" + num1*num2);
                    break;
                case "/":
                    Console.WriteLine("DIVISION =" + num1/num2);
                    break;
                default:
                    Console.WriteLine("not valid operation symbol");
                    break;
            }

          
            
        }
    }
}

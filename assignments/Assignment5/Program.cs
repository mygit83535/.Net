using Assignment4;
namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            Student[] students;
            Console.WriteLine("Enter the size of array");
            size = Convert.ToInt32(Console.ReadLine());
            students = CreateArray(size);
            AcceptInfo(students, size);
            PrintInfo(students);
            Console.WriteLine("reverse array");
            ReverseArray(students, size);
            PrintInfo(students);
        }
        static void ReverseArray(Student[] students, int size)
        {
            Student[] result = new Student[size];

            for (int i = 0; i<size;i++)
            {
                result[i] = students[i];
            }

            int index = 0;
            for (int i = size - 1; i >= 0; i--)
            {
                students[index++] = result[i];
            }

        }

        static void PrintInfo(Student[] students)
        {
            foreach (Student student in students)
            {
                student.PrintDetails();
            }
        }
        static void AcceptInfo(Student[] students, int size)
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i].AcceptDetails();
            }
        }
        static Student[] CreateArray(int size)
        {
            return new Student[size];
        }

    }
}

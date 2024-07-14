using Assignment13;
namespace Assignment14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            Console.WriteLine("Enter the company Name-");
            company.Name = Console.ReadLine();
            Console.WriteLine("Enter the company Address-");
            company.Address = Console.ReadLine();
            int choice;
            List<Employee> employees = new List<Employee>();
            do
            {
                Console.WriteLine("0. EXIT");
                Console.WriteLine("1. ADD Employee");
                Console.WriteLine("2. Remove Emloyee");
                Console.WriteLine("3. Find employee by id");
                Console.WriteLine("4. Display the company and all employees details");
                Console.WriteLine("Enter your choice-");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Thank you.......");
                        break;
                    case 1:
                        int empchoice = choiceEmployee();
                        if (empchoice > 0 && empchoice < 3)
                        {
                            Employee emp = Factory.getEmployee(choice);
                            emp.Accept();
                            employees.Add(emp);
                            Console.WriteLine("Employee added successfully");
                        }
                        else
                        {
                            Console.WriteLine("WRONG CHOICE");
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter the employee id to delete employee");
                            int empid = Convert.ToInt32(Console.ReadLine());
                            Employee demp = null;
                            foreach (Employee emp in employees)
                            {
                                if (emp.id == empid)
                                {
                                    demp = emp;
                                }
                            }
                            if (demp != null)
                            {
                                employees.Remove(demp);
                            }
                            else
                                Console.WriteLine("Employee not found!");
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter the employee id to find employee");
                            int empid = Convert.ToInt32(Console.ReadLine());
                            Employee demp = null;
                            foreach (Employee emp in employees)
                            {
                                if (emp.id == empid)
                                {
                                    demp = emp;
                                }
                            }
                            if (demp != null)
                            {
                                demp.Print();
                            }
                            else
                                Console.WriteLine("Employee not found..");
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Employee Name-"+company.Name);
                            Console.WriteLine("Employee Address-"+company.Address);
                            foreach(Employee employee in employees)
                            {
                                employee.Print();
                                Console.WriteLine("-----------------------------------------------------------------");
                            }
                        }
                        break;
                }

            } while (choice != 0);
        }

        public static int choiceEmployee()
        {
            Console.WriteLine("Enter the choice of employee--");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Supervisor");
            Console.WriteLine("3. Wage");
            Console.WriteLine("Enter your choice");
            return Convert.ToInt32(Console.ReadLine());
        }
    }

    public class Factory
    {
        public static Employee getEmployee(int choice)
        {
            if (choice == 1)
                return new Manager();
            else if (choice == 2)
            {
                return new Supervisore();
            }
            else
            {
                return new WageEmp();
            }
        }
    }
}

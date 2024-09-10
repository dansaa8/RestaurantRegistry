namespace RestaurantRegistry;

class Program
{
    private static List<Employee> employees = new();

    static void Main(string[] args)
    {
        string? choice;
        do
        {
            Console.Clear();
            Console.WriteLine("*** RESTAURANT REGISTRY ***\n");
            Console.WriteLine("OPTIONS:");
            Console.WriteLine("[R]egister new employee");
            Console.WriteLine("[S]how employees");
            Console.WriteLine("[E]xit");

            choice = Console.ReadLine().ToLower();
            switch (choice)
            {
                case "r":
                    Console.Clear();
                    employees.Add(Employee.Create());
                    break;
                case "s":
                    Console.Clear();
                    Console.WriteLine("*** Employees ***\n");
                    foreach (Employee employee in employees)
                    {
                        Console.WriteLine($"{employee.FirstName} {employee.LastName}");
                        Console.WriteLine($"Salary: {employee.Salary}\n");
                    }

                    Console.ReadKey();
                    break;
                case "e":
                    Console.Clear();
                    Console.WriteLine("Goodbye! :-)");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    Console.ReadKey();
                    break;
            }
        } while (choice != "e");
    }
}
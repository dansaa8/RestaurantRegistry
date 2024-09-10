namespace RestaurantRegistry;

public class Employee
{
    public string FirstName { get; }
    public string LastName { get; }
    public decimal Salary { get; }

    private Employee(string firstName, string lastName, decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }

    public static Employee Create()
    {
        string firstName = Utilities.ReadName("First name");
        string lastName = Utilities.ReadName("Last name");
        decimal salary = Utilities.ReadSalary();

        return new Employee(firstName, lastName, salary);
    }
}
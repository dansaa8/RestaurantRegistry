namespace RestaurantRegistry;

public static class Utilities
{
    public static string ReadName(string nameType)
    {
        string? nameInput;
        Console.Write($"{nameType}: ");

        while (string.IsNullOrWhiteSpace(nameInput = Console.ReadLine()))
        {
            Console.WriteLine($"Input empty. Please enter the {nameType} again: ");
        }

        return nameInput;
    }

    public static decimal ReadSalary()
    {
        Console.Write("Enter salary: ");
        while (true)
        {
            string? salaryInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(salaryInput))
            {
                Console.WriteLine("Input empty. Please enter the salary again: ");
                continue;
            }

            if (decimal.TryParse(salaryInput, out decimal salary))
            {
                return salary;
            }

            Console.WriteLine("Invalid salary. Please enter a valid decimal number");
        }
    }
}
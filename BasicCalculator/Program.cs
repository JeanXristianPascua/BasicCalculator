using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice (1-5): ");

            string choice = Console.ReadLine();

            if (choice == "5")
            {
                Console.WriteLine("Exiting the calculator. Goodbye!");
                break;
            }

            try
            {
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Result: {num1 + num2}");
                        break;
                    case "2":
                        Console.WriteLine($"Result: {num1 - num2}");
                        break;
                    case "3":
                        Console.WriteLine($"Result: {num1 * num2}");
                        break;
                    case "4":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Cannot divide by zero.");
                        }
                        else
                        {
                            Console.WriteLine($"Result: {num1 / num2}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numerica values.");
            }

            Console.WriteLine(); // Add a blank line for better readability
        }
    }
}
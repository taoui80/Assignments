// See https://aka.ms/new-console-template for more information

namespace ConditionalStatements;
class Program
{
    static void Main(string[] args)
    {
        // Assignment 1. Usage of the VAT calculation method
        {
            Console.WriteLine("Enter the product type(music, food, alcohol): ");
            string? product = Console.ReadLine()?.ToLower(); // Read user input and convert to lowercase

            Console.WriteLine("Enter the price of that product: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            decimal vat = MethodCalls.CalculateVAT(product, price);
            Console.WriteLine($"The VAT for {product} at price {price} is {vat}");
        }

        // Assignment 2. Usage of the gym membership price calculation method
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Do you want a premium membership? (true/false): ");
            bool isPremium = Convert.ToBoolean(Console.ReadLine());

            int totalPrice = MethodCalls.CalculateMembershipPrice(age, isPremium);
            Console.WriteLine($"The total price for your gym membership is: {totalPrice}");
        }

        // Assignment 3. Usage of the calculator method
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operation (+, -, *, /): ");
            string? operation = Console.ReadLine();

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double calculatorResult = MethodCalls.Calculator(operation, num1, num2);
            Console.WriteLine($"The result is: {calculatorResult}");
        }

        // Assignment 4. Usage of the SelectMenuOption method
        {
            Console.WriteLine("Enter a menu option: (help, add, delete, edit, find, list)");
            string? selected = Console.ReadLine()?.ToLower();

            // Call the method with the user's selection
            MethodCalls.SelectMenuOption(selected);
        }
    }
}

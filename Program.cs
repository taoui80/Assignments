// See https://aka.ms/new-console-template for more information

namespace ConditionalStatements;
class Program
{
    static void Main(string[] args)
    {
        // Assignment Object constructors

        // Create a CurrencyConverter instance
        CurrencyConverter converter = new CurrencyConverter();

        // Create an Account instance with an initial balance in SEK
        Account account = new Account
        {
            Id = 1,
            Balance = new Money(1000m, Currency.SEK)
        };

        Console.WriteLine($"Initial Balance: {account.Balance.Amount:F2} {account.Balance.Currency}");

        // Convert the balance from SEK to Dollar
        account.Balance.ConvertCurrency(converter, Currency.Dollar);
        Console.WriteLine($"Balance after conversion to Dollar: {account.Balance.Amount:F2} {account.Balance.Currency}");

        // Convert the balance from Dollar to Euro
        account.Balance.ConvertCurrency(converter, Currency.Euro);
        Console.WriteLine($"Balance after conversion to Euro: {account.Balance.Amount:F2} {account.Balance.Currency}");

        // Convert the balance back to SEK
        account.Balance.ConvertCurrency(converter, Currency.SEK);
        Console.WriteLine($"Balance after conversion back to SEK: {account.Balance.Amount:F2} {account.Balance.Currency}");


        /*
        // Assignment 1. Usage of the VAT calculation method
        {
            Console.WriteLine("Enter the product type(music, food, alcohol): ");
            string? product = Console.ReadLine()?.ToLower(); // Read user input and convert to lowercase

            Console.WriteLine("Enter the price of that product: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            decimal vat = ServiceMethods.CalculateVAT(product, price);
            Console.WriteLine($"The VAT for {product} at price {price} is {vat}");
        }

        // Assignment 2. Usage of the gym membership price calculation method
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Do you want a premium membership? (true/false): ");
            bool isPremium = Convert.ToBoolean(Console.ReadLine());

            int totalPrice = ServiceMethods.CalculateMembershipPrice(age, isPremium);
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

            double calculatorResult = ServiceMethods.Calculator(operation, num1, num2);
            Console.WriteLine($"The result is: {calculatorResult}");
        }

        // Assignment 4. Usage of the SelectMenuOption method
        {
            Console.WriteLine("Enter a menu option: (help, add, delete, edit, find, list)");
            string? selected = Console.ReadLine()?.ToLower();

            // Call the method with the user's selection
            ServiceMethods.SelectMenuOption(selected);
        }
        */
    }
}

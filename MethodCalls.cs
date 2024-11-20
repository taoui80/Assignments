using System;

namespace ConditionalStatements;

public class MethodCalls
{
    // Assignment 1. - Method to calculate VAT
    public static decimal CalculateVAT(string? product, decimal price)
    {
        decimal vatRate;

        // Determine VAT rate based on product type
        switch (product)
        {
            case "music":
                vatRate = 0.06m; // The VAT is 6% for music entertainment
                break;
            case "food":
                vatRate = 0.12m; // The VAT is 12% for food
                break;
            case "alcohol":
                vatRate = 0.25m; // The VAT is 25% for alcohol
                break;
            default:
                throw new ArgumentException("Invalid product type. Please use 'music', 'food', or 'alcohol'.");
        }

        // Calculate and return VAT
        return vatRate * price;
    }

    //Assignment 2 - Method to calculate the price when signing up for a gym membership.
    public static int CalculateMembershipPrice(int age, bool isPremium)
    {
        int gymMembershipPrice;

        // Determine the base price based on age
        if (age < 19 || age > 64)
        {
            gymMembershipPrice = 2200;
        }
        else
        {
            gymMembershipPrice = 3100;
        }

        // Add premium membership cost if selected
        if (isPremium)
        {
            gymMembershipPrice += 300;
        }

        return gymMembershipPrice;
    } 

    // Assignment 3 - Method to calculate mathematical operation
    public static double Calculator(string? operation, double num1, double num2)
    {
    switch (operation)
        {
        case "+":
            return num1 + num2;
        case "-":
            return num1 - num2;
        case "*":
            return num1 * num2;
        case "/":
            if (num2 == 0)
            throw new DivideByZeroException("Division by zero is not allowed.");
            return num1 / num2;
        default:
            throw new ArgumentException("Invalid operation. Please use +, -, *, or /.");
        }
    }

    // Assignment 4. - A menu option method that print out unique message for the selected one
    public static void SelectMenuOption(string? optionSelected)
    {
    switch(optionSelected)
        {
	    case "help": 
		    Console.WriteLine("You chose 'help'. Here are general guidelines for the menu");
		    break;

	    case "add": 
		    Console.WriteLine("You chose 'add'. Here are guidelines on how you add an option");
		    break;
	
	    case "delete": 
		    Console.WriteLine("You chose 'delete'. Here are guidelines on how you delete an option");
		    break;

	    case "edit": 
		    Console.WriteLine("You chose 'edit'. Here are guidelines on how you edit an option");
		    break;

	    case "find": 
		    Console.WriteLine("You chose 'find'. Here are guidelines on how you search for an option");
		    break;

	    case "list": 
		    Console.WriteLine("You chose 'list'. Here are guidelines on how you display all options");
		    break;

	    default:
		    Console.WriteLine("Invalid option. Please try again.");
            break;
        }
 
    }

}

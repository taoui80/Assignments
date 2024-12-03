using System;

namespace ConditionalStatements;

public class Money
{
    //Properties  
    public decimal Amount { get; private set; }
    public Currency Currency { get; private set; }


    //Constructor
    public Money(decimal amount, Currency currency)
    {
        this.Amount = amount;
        this.Currency = currency;

    }
    //Converts Money object to different currencies
    public void ConvertCurrency(CurrencyConverter converter, Currency newCurrency)
    {

        if (Currency == newCurrency)
        {
            return;
        }

        Amount = converter.ConvertAmount(Amount, Currency, newCurrency);
        Currency = newCurrency;

    }
}

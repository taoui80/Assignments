using System;

namespace ConditionalStatements;

public class CurrencyConverter
{
    private const decimal sekToDollarRate = 0.095m;
    private const decimal sekToEuroRate = 0.085m;

    private const decimal dollarToSekRate = 1 / sekToDollarRate;
    private const decimal dollarToEuroRate = sekToEuroRate / sekToDollarRate;

    private const decimal euroToSekRate = 1 / sekToEuroRate;
    private const decimal euroToDollarRate = sekToDollarRate / sekToEuroRate;

    //Convert an amount from one currency to another
    public decimal ConvertAmount(decimal amount, Currency fromCurrency, Currency toCurrency)
    {
        if (fromCurrency == toCurrency)
            return amount;

        switch (fromCurrency)
        {
            case Currency.SEK:
                switch (toCurrency)
                {
                    case Currency.Dollar:
                        return amount * sekToDollarRate;
                    case Currency.Euro:
                        return amount * sekToEuroRate;
                }
                break;

            case Currency.Dollar:
                switch (toCurrency)
                {
                    case Currency.SEK:
                        return amount * dollarToSekRate;
                    case Currency.Euro:
                        return amount * dollarToEuroRate;
                }
                break;

            case Currency.Euro:
                switch (toCurrency)
                {
                    case Currency.SEK:
                        return amount * euroToSekRate;
                    case Currency.Dollar:
                        return amount * euroToDollarRate;
                }
                break;

            default:
                throw new ArgumentException("Invalid currency conversion");
        }

        // If no valid conversion case is matched
        throw new ArgumentException("Invalid currency conversion");
    }
}

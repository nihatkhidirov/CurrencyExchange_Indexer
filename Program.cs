namespace CurrencyEnum_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Currency currency = Currency.Try;
            double value = 970;
            double converting = Exchange(currency, value);
           
        }
        public static double Exchange(Currency currency, double value) //usd 
        {
            double azntousdt = 0.59;
            double azntoeur = 0.54;
            double azntotry = 19;
            double converted = 0;
            if(Enum.IsDefined(typeof(Currency), currency))
            {
                switch (currency)
                {
                    case Currency.Usd:
                        converted = value * azntousdt;
                        Console.WriteLine($"Mubadileye esasen: {value} AZN = {converted} USD ");

                        break;
                    case Currency.Euro:
                        converted = value * azntoeur;
                        Console.WriteLine($"Mubadileye esasen: {value} AZN = {converted} EUR ");

                        break;
                    case Currency.Try:
                        converted = value * azntotry;
                        Console.WriteLine($"Mubadileye esasen: {value} AZN = {converted} TRY ");

                        break;
                }
            }
            else
            {
                Console.WriteLine("Duzgun valyuta daxil edilmemisdir!");
            }
            return converted;
        }
    }
}
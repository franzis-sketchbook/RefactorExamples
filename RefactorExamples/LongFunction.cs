namespace RefactorExamples;

public class LongFunction
{
    public static void LongFunctionMethod()
    {
        Console.WriteLine("****************************");
        Console.WriteLine("**** Customers Licenses ****");
        Console.WriteLine("****************************");

        Customer customer = new("Otto Ostwind", new() { new("Word", 100M), new License("Excel", 300M) }, 10000M);
        foreach (var license in customer.Licenses)
        {
            Console.WriteLine($"For license {license.Name} you pay {license.Price}");
        }

        foreach (var license in customer.Licenses)
        {
            decimal priceForAllLicenses = license.Price * license.NumberOfLicenses;
            Console.WriteLine($"You paid {priceForAllLicenses} for all licenses of {license.Name}.");
        }

        decimal totalPrice = 0;
        foreach (var license in customer.Licenses)
        {
            decimal priceForAllLicenses = license.Price * license.NumberOfLicenses;
            totalPrice += priceForAllLicenses;
        }
        
        Console.WriteLine($"All in all you paid {totalPrice}.");

        if (customer.Budget > totalPrice)
        {
            Console.WriteLine($"Congratulations you bought licenses for {totalPrice}.");
        }
        else
        {
            Console.WriteLine($"Bad news, to buy licenses for {totalPrice} you take out a loan of {totalPrice - customer.Budget}.")
        }
    }
}

public class Customer
{
    public Customer(string name, List<License> licenses, decimal budget)
    {
        Name = name;
        Licenses = licenses;
        Budget = budget;
    }

    public string Name { get; set; }
    public List<License> Licenses { get; set; }
    public decimal Budget { get; set; }
}

public class License
{
    public License(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    public License(string name, decimal price, int numberOfLicenses)
    {
        Name = name;
        Price = price;
        NumberOfLicenses = numberOfLicenses;
    }

    public string Name { get; set; }
    public decimal Price { get; set; }
    public int NumberOfLicenses { get; set; }
}

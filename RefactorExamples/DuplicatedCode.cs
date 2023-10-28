namespace RefactorExamples;

public class DuplicatedCode
{
    public static void DuplicatedCodeMethod()
    {
        Console.WriteLine("****************************");
        Console.WriteLine("**** Customers Licenses ****");
        Console.WriteLine("****************************");

        Customer customer = new("Otto Ostwind ", new() { new("Word", 100M), new License("Excel", 300M) }, 10000M);
        foreach (var license in customer.Licenses)
        {
            Console.WriteLine($"For license {license.Name} you pay {license.Price}");
        }


        Console.WriteLine("****************************");
        Console.WriteLine("**** Customers Licenses ****");
        Console.WriteLine("****************************");

        Customer customer2 = new("Max Mustermann", new() { new("Teams", 50M, 100), new License("OneNote", 300M, 20) }, 200000M);
        foreach (var license in customer2.Licenses)
        {
            Console.WriteLine($"You have {license.NumberOfLicenses} licenses of {license.Name}");
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
}

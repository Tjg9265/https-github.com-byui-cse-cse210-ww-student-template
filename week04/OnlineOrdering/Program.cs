using System;

class Program
{
    static void Main(string[] args)
    {
        // --------------------- ORDER 1 ---------------------
        Address address1 = new Address("123 Apple St", "Mesa", "AZ", "USA");
        Customer customer1 = new Customer("Thomas Garcia", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Keyboard", "KB100", 29.99, 2));
        order1.AddProduct(new Product("Mouse", "MS220", 19.50, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}\n");

        // --------------------- ORDER 2 ---------------------
        Address address2 = new Address("456 Maple Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Sarah Johnson", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tent", "TN300", 120.00, 1));
        order2.AddProduct(new Product("Sleeping Bag", "SB110", 80.00, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}\n");
    }
}

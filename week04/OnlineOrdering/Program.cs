using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address addr1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Customer cust1 = new Customer("John Doe", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Keyboard", "KB001", 49.99m, 2));
        order1.AddProduct(new Product("Mouse", "MS002", 19.99m, 1));

        // Order 2
        Address addr2 = new Address("456 Elm Rd", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Jane Smith", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Monitor", "MN003", 149.99m, 1));
        order2.AddProduct(new Product("Webcam", "WC004", 89.50m, 1));
        order2.AddProduct(new Product("Microphone", "MC005", 120.00m, 1));

        DisplayOrder(order1);
        Console.WriteLine(new string('-', 40));
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("PACKING LABEL:\n" + order.GetPackingLabel());
        Console.WriteLine("SHIPPING LABEL:\n" + order.GetShippingLabel());
        Console.WriteLine($"TOTAL PRICE: ${order.GetTotalCost():0.00}");
    }
}

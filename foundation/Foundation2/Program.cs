public class Program
{
    public static void Main()
    {
         // Create products
        Product product1 = new Product("Laptop", "P12345", 1000m, 2);
        Product product2 = new Product("Mouse", "P67890", 25m, 1);
        Product product3 = new Product("Keyboard", "P11223", 50m, 3);

        // Create addresses
        Address address1 = new Address("123 Main St", "New York", "NY", "United States");
        Address address2 = new Address("456 Oak Rd", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Alice Johnson", address1);
        Customer customer2 = new Customer("Bob Smith", address2);

        // Create orders
        Order order1 = new Order(new List<Product> { product1, product2 }, customer1);
        Order order2 = new Order(new List<Product> { product3 }, customer2);

        // Show labels and costs
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.GetTotalCost():C2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.GetTotalCost():C2}");
    }
}

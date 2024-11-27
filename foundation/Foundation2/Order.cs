public class Order
{
    // Private attributes
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    // Method for calculating the total cost of the order
    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }
        
        // Calculation of shipping cost
        decimal shippingCost = _customer.GetAddress().IsInUS() ? 5m : 35m;
        total += shippingCost;
        return total;
    }

    // Method of obtaining the packaging label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetId()})\n";
        }
        return label;
    }

    // Method to obtain the shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetCustomerInfo()}";
    }
}

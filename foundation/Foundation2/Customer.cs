public class Customer
{
    // Private attributes
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Getter methods
    public string GetName() => _name;
    public Address GetAddress() => _address;

    // Method that returns the complete client information
    public string GetCustomerInfo()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
}

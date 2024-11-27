public class Product
{
    // Private attributes with the appropriate convention
    private string _name;
    private string _id;
    private decimal _price;
    private int _quantity;

    // Constructor
    public Product(string name, string id, decimal price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    // Getter methods
    public string GetName() => _name;
    public string GetId() => _id;
    public decimal GetPrice() => _price;
    public int GetQuantity() => _quantity;

    // Método para calcular el costo total del producto
    public decimal GetTotalCost() => _price * _quantity;
}

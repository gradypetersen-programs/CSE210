public class Product
{
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double CalculateCost()
    {
        return _price * _quantity;
    }

    public string MakeString()
    {
        string productString = $"{_productName} ID: {_productId}\n{_quantity} @ ${_price:0.00}\nProduct Total: ${CalculateCost():0.00}";
        return productString;
    }
}
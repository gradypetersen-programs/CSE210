// Order: products(List<product>), customer(Customer), 
//                 methods: CalculateTotal, MakePackingLabel, MakeShippingLabel
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotal()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.CalculateCost();
        }
        int shippingCharge = 5;
        if (!_customer.IsInUsa())
        {
            shippingCharge = 35;
        }
        totalCost += shippingCharge;
        return totalCost;
    }

    public string MakePackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += product.MakeString() + "\n";
        }
        return packingLabel;
    }

    public string MakeShippingLabel()
    {
        return _customer.MakeString();
    }
}
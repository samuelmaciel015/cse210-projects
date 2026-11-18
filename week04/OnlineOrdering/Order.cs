public class Order
{
    //member variables
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    //constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }
    //member methods
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalPrice();
        }

        if (_customer.LivesInUSA())
        {
            return totalCost + 5;
        }
        else
        {
            return totalCost + 35;
        }


    }
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetId()})\n";
        }

        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"Shipping to:\n{_customer.GetName()}\n{_customer.GetAddress().DisplayAddress()}";
    }
}
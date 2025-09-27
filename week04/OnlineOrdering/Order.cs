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

    //get methods
    public List<Product> GetProducts()
    {
        return _products;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }

    //member methods
    public void AddProduct(Product newProduct)
    {
        GetProducts().Add(newProduct);
    }
    public void OrderTotalCost()
    {
        double total = 0;
        foreach (Product product in GetProducts())
        {
            total += product.TotalCost();
        }

        if (GetCustomer().LiveInUSA() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        Console.WriteLine($"The total price is ${total} dollars");
        Console.WriteLine();
    }
    public void MakePackingLabel()
    {
        Console.WriteLine("PACKING LABEL");
        foreach (Product product in GetProducts())
        {
            Console.WriteLine($"ID: {product.GetId()} --- Product: {product.GetName()}");
        }
        Console.WriteLine("------------------------------------------");
    }
    public void MakeShippingLabel()
    {
        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine($"Customer: {GetCustomer().GetName()} -- Address: {GetCustomer().GetAddress().GetAddress()}");
        Console.WriteLine("------------------------------------------");
    }

}
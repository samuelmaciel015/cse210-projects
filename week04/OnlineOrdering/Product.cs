public class Product
{
    //member variables
    private string _productName;
    private int _productId;
    private double _productPrice;
    private int _productQuantity;

    //construtor
    public Product(string name, int id, double price, int quantity)
    {
        _productName = name;
        _productId = id;
        _productPrice = price;
        _productQuantity = quantity;
    }

    //member methods
    public string GetName()
    {
        return _productName;
    }
    public int GetId()
    {
        return _productId;
    }
    public double GetTotalPrice()
    {
        return _productPrice * _productQuantity;
    }
}
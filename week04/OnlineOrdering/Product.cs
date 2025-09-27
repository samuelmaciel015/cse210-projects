public class Product
{
    //member variables
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    //constructor
    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    //get methods
    public string GetName()
    {
        return _name;
    }
    public int GetId()
    {
        return _id;
    }
    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }

    //member methods
    public double TotalCost()
    {
        return GetPrice() * GetQuantity();
    }
    }
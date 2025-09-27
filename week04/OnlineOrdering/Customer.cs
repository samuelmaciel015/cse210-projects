public class Customer
{
    //member variables
    private string _name;
    private Address _address;

    //constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //get methods
    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }

    //member methods
    public bool LiveInUSA()
    {
        return _address.LiveInUSA();
    }

}
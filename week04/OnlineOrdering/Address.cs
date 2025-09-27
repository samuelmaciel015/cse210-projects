public class Address
{
    //member variables
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    //constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    //get methods
    public string GetStreet()
    {
        return _street;
    }
    public string GetCity()
    {
        return _city;
    }
    public string GetState()
    {
        return _state;
    }
    public string GetCountry()
    {
        return _country;
    }

    //member methods
    public bool LiveInUSA()
    {
        return _country.ToUpper() == "USA";
    }
    public string GetAddress()
    {
        return $"{GetStreet()}, {GetCity()} - {GetState()}, {GetCountry()}";
    }
}
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

    //member methods
    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }
    public string DisplayAddress()
    {
        return $"{_street}\n{_city}, {_state} \n{_country}";
    }
}
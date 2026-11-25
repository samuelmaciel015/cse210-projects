public class Customer {
    //member variables
    private string _customerName;
    private Address _customerAddress;

    //constructor
    public Customer(string name, Address address) {
        _customerName = name;
        _customerAddress = address;
    }

    //member methods
    public bool LivesInUSA() {
        return _customerAddress.IsInUSA();
    }

    public string GetName() {
        return _customerName;
    }

    public Address GetAddress() {
        return _customerAddress;
    }
}
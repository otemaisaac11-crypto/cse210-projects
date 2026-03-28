public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string address)
    {
        _name = name;
        _address = new Address(address);
    
    }

    public bool IsInUSA()
    {
        return _addresss.IsInUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetFullAddress();
    }
}

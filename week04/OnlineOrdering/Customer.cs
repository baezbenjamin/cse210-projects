public class Customer
{
    private string _customerName;
    private Address _address;
    private bool _livesInUsa;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public void LivesInUsa()
    {
        if (_address.AddressInUsa() == false)
        {
            _livesInUsa = false;
        }
        else
        {
            _livesInUsa = true;
        }
    }

    public string DisplayCustomer()
    {
        return $"Customer Name: {_customerName}\nAddress: {_address.DisplayAddress}";
    }
}
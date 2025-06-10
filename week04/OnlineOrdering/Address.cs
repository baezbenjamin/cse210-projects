public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool AddressInUsa()
    {
        if (_country != "USA")
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public string DisplayAddress()
    {
        return $"{_street}, {_city}, {_stateOrProvince}, {_country}";
    }
}
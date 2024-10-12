class Customers
{
    private string _name;
    private Address _address;

    public Customers(string name, Address address)
    {
        _name = name;
        _address = address;
    } 

    public string CustomerInfo()
    {
        string infos = $"{_name} \n{_address.GetAddress()}";
        return infos;
    }

    public bool OriginCountry()
    {
        return _address.OriginCountry();
    }

}
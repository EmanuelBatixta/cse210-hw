class Products
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;
    private double _finalValue;

    public Products(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string ItemInfo()
    {
        string item = $"{_id}: {_name}";
        return item;
    }
    public double CalculateFinal()
    {
        _finalValue = _price * _quantity;
        return _finalValue;
    }
}

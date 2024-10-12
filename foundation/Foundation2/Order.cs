class Orders
{
    private List<Products> _products;
    private Customers _customer;
    private int _shippingCost;
    private double _amount;

    public Orders(Customers customer, List<Products> product)
    {
        _customer = customer;
        _products = product;
    }
    public void TotalValue()
    {
        if(_customer.OriginCountry())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }

        foreach(Products product in _products)
        {
            double price = product.CalculateFinal();
            _amount += price;
        }

        _amount += _shippingCost;
    }

    public void PackingLabel()
    {
        foreach(Products product in _products)
        {
            Console.WriteLine($"{product.ItemInfo()}");
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine(_customer.CustomerInfo());
    }
}
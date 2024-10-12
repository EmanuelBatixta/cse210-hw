using System;

class Program
{
    static void Main(string[] args)
    {
        List<Products> _products = new List<Products>();
        Address _address = new Address("Morro Bonito","Jacarei","Minas Gerais","BR");
        Customers _customer = new Customers("Emanuel Jonatas", _address);
        Orders _orders = new Orders(_customer, _products);

        Products shoes = new Products("Shoes","SHO12",290.00,2);
        Products tShirt = new Products("T-Shirt","TSH89",88.99,4);
        Products skirt = new Products("Skirt","SKI14",29.00,2);
        Products suit = new Products("Suit","SUT36",899.89,1);
        Products pants = new Products("Pants","PAN25",78.34,3);

        _products.Add(shoes);
        _products.Add(tShirt);
        _products.Add(skirt);
        _products.Add(suit);
        _products.Add(pants);

        _orders.TotalValue();

        _orders.PackingLabel();
        _orders.ShippingLabel();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Products> _products1 = new List<Products>();
        Address _address = new Address("Morro Bonito","Jacarei","Minas Gerais","BR");
        Customers _customer = new Customers("Emanuel Jonatas", _address);
        Orders _orders = new Orders(_customer, _products1);

        List<Products> _products2 = new List<Products>();
        Address _address2 = new Address("Bosque","Cruzeiro do Sul","Bahia","BR");
        Customers _customer2 = new Customers("Rogerio", _address2);
        Orders _orders2 = new Orders(_customer2, _products2);

        Products shoes = new Products("Shoes","SHO12",290.00,2);
        Products tShirt = new Products("T-Shirt","TSH89",88.99,4);
        Products skirt = new Products("Skirt","SKI14",29.00,2);
        Products suit = new Products("Suit","SUT36",899.89,1);
        Products pants = new Products("Pants","PAN25",78.34,3);

        _products1.Add(shoes);
        _products1.Add(tShirt);
        _products2.Add(skirt);
        _products2.Add(suit);
        _products1.Add(pants);

        _orders.TotalValue();

        Console.WriteLine("\nPacking Label: ");
        _orders.PackingLabel();

        Console.WriteLine("\nShipping Label: ");
        _orders.ShippingLabel();

        _orders2.TotalValue();

        Console.WriteLine("\nPacking Label: ");
        _orders2.PackingLabel();

        Console.WriteLine("\nShipping Label: ");
        _orders2.ShippingLabel();
        Console.WriteLine("\n");
    }
}
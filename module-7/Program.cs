abstract class Delivery
{
    protected string CourierName { get; set; }
    public string PickPointName { get; set; }
    protected DateTime DeliveryDate { get; set; }
    protected Address HomeAddress { get; set; }
    public Address PickPointAddress { get; set; }
    public Address ShopAddress { get; set; }
}

class HomeDelivery : Delivery
{
    protected string CourierName { get; set; }
    protected DateTime DeliveryDate { get; set; }
    protected Address HomeAddress { get; set; }
}
class PickPointDelivery : Delivery
{
    protected DateTime DeliveryDate { get; set; }
    public string PickPointName { get; set; }
    public Address PickPointAddress { get; set; }
}
class ShopDelivery : Delivery
{
    protected DateTime DeliveryDate { get; set; }
    public Address ShopAddress { get; set; }
}

class Address
{
    protected string Country { get; set; }
    protected string City { get; set; }
    protected string Street { get; set; }
    protected string PostalCode { get; set; }
}

abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public int Count { get; set; }

    public Product(string name, decimal price, int count)
    {
        Name = name;
        Price = price;
        Count = count;
    }
    public virtual decimal CalculateTotal()
    {
        return Price * Count;
    }
}

class Order
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public int Count { get; set; }

    public List<Product> Products { get; set; }
    public string Address { get; set; }
    protected DateTime DeliveryDate { get; set; }

    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (Product product in Products)
        {
            total += product.CalculateTotal();
        }
        return total;
    }
}

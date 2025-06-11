public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer, List<Product> product)
    {
        _customer = customer;
        _products = product;
    }

    public double TotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in _products)
            totalPrice += product.TotalCost();
        if (_customer.LivesInUsa() == true)
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }
        return totalPrice;
    }
    public string PackingLabel()
    {
        string packingLabel = "Products List:\n";
        foreach (Product product in _products)
        {
            packingLabel = packingLabel + product.DisplayProduct() + "\n";
        }
        return packingLabel;
    }

    public string ShippingLabel()
    {
        return $"{_customer.DisplayCustomer()}";
    }

    public string DisplayTotalPrice()
    {
        return $"Total Price: {TotalPrice()}\n";
    }
}
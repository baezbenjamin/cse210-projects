public class Product
{
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        return _price * _quantity;
    }

    public string DisplayProduct()
    {
        return $"Product: {_productName}\nID: {_productId}";
    }
}
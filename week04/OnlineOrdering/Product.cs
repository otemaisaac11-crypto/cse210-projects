public class Product
{
    private string _name;
    private string _ID;
    private double _price;
    private int _quantity;

    public Product (string name, string ID, double price, int quantity)
    {
        _name = name;
        _ID = ID;
        _price = price;
        _quantity = quantity;
    }

    public  double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetPackingInfo()
    {
        return ($"{_name}\n, ID:{_ID}");
    }

}
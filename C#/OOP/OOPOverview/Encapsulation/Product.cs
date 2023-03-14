namespace Encapsulation;

public class Product
{
    private double _price;

    public void SetPrice(double value)
    {
        if (value > 0)
        {
            _price = value;
        }
        throw new ArgumentException($"{value} değeri kabul edilemez");
    }

    public double GetPrice()
    {
        return _price;
    }

    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Stock { get; set; }
    public bool IsInStock { get { return Stock > 50; } }
}

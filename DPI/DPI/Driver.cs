using DPI;

public class Driver : IDriver
{
    private readonly string _name;

    public Driver(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
}
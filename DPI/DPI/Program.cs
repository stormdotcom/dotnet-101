using DPI;

class Program
{
    static void Main(string[] args)
    {
        var car = new Car(new Driver("John"));
        car.Start();
    }
}
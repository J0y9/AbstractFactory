namespace AbstractFactory;

public class VictorianSofa : ISofa
{
    public void HasLegs()
    {
        Console.WriteLine("Victorian Sofa ");

    }

    public void SitOn()
    {
        Console.WriteLine("Sitting on Victorian Sofa ");

    }
}
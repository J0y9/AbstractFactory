namespace AbstractFactory;

public class VictorianChair : IChair
{
    public void HasLegs()
    {
        Console.WriteLine("Victorian Chair ");
    }

    public void SitOn()
        {
            Console.WriteLine("Sitting on Victorian Chair ");
    }
}
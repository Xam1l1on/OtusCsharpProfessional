namespace DemonstrationOfSolidPrinciples;

public class SimpleRandomNumberGenerator : IRandomNumberGenerator
{
    private Random _random = new Random();
    public int Generate(RangeNumber range) => _random.Next(range.MinNumber, range.MaxNumber + 1);
}

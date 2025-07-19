namespace DemonstrationOfSolidPrinciples;

public class SimpleRandomNumberGenerator : IRandomNumberGenerator
{
    private Random _random = new Random();
    public int Generate(int min, int max) => _random.Next(min, max + 1);
}

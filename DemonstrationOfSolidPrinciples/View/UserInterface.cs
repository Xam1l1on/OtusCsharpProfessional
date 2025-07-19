namespace DemonstrationOfSolidPrinciples;

public class UserInterface : IUserInterface
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public int GetUserGuess()
    {
        Console.Write("Введите число: ");
        return int.Parse(Console.ReadLine());
    }
}

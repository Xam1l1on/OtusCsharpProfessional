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
        int.TryParse(Console.ReadLine(), out int _num);
        return _num;
    }
}

namespace DemonstrationOfSolidPrinciples;

public class DefaultMessageProvider : IMessageProvider
{
    public string GetMessage(GuessResult result)
    {
        switch (result)
        {
            case GuessResult.Correct:
                return "Поздравляю! Вы угадали число!";
            case GuessResult.TooLow:
                return "Загаданное число больше.";
            case GuessResult.TooHigh:
                return "Загаданное число меньше.";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}

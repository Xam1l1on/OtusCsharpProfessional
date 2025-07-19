namespace DemonstrationOfSolidPrinciples;

public class GameLogic : IGameLogic
{
    private readonly IUserInterface _ui;
    private readonly IRandomNumberGenerator _random;
    private readonly IMessageProvider _messageProvider;

    public GameLogic(IUserInterface ui, IRandomNumberGenerator random, IMessageProvider messageProvider)
    {
        _ui = ui;
        _random = random;
        _messageProvider = messageProvider;
    }

    public void StartGame()
    {
        int numberToGuess = _random.Generate(new RangeNumber { MinNumber = 1, MaxNumber = 100 });

        while (true)
        {
            int userGuess = _ui.GetUserGuess();

            GuessResult result = DetermineGuessResult(userGuess, numberToGuess);
            string message = _messageProvider.GetMessage(result);
            _ui.ShowMessage(message);
            if (result == GuessResult.Correct)
            {
                return;
            }
        }
    }
    private GuessResult DetermineGuessResult(int userGuess, int numberToGuess)
    {
        if (userGuess == numberToGuess) return GuessResult.Correct;
        else if (userGuess < numberToGuess) return GuessResult.TooLow;
        else return GuessResult.TooHigh;
    }
}

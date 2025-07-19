namespace DemonstrationOfSolidPrinciples;

public class GameLogic : IGameLogic
{
    private readonly IUserInterface _ui;
    private readonly IRandomNumberGenerator _random;
    private readonly IMessageProvider _messageProvider;
    private readonly int _maxAttempts;

    public GameLogic(IUserInterface ui, IRandomNumberGenerator random, IMessageProvider messageProvider, int maxAttempts)
    {
        _ui = ui;
        _random = random;
        _messageProvider = messageProvider;
        _maxAttempts = maxAttempts;
    }

    public void StartGame()
    {
        int numberToGuess = _random.Generate(1, 100);
        int attempts = 0;

        while (attempts < _maxAttempts)
        {
            int userGuess = _ui.GetUserGuess();
            attempts++;

            GuessResult result = DetermineGuessResult(userGuess, numberToGuess);
            string message = _messageProvider.GetMessage(result);
            _ui.ShowMessage(message);

            if (result == GuessResult.Correct)
            {
                return;
            }
        }

        _ui.ShowMessage("Игра окончена! Вы исчерпали все попытки.");
    }

    private GuessResult DetermineGuessResult(int userGuess, int numberToGuess)
    {
        if (userGuess == numberToGuess) return GuessResult.Correct;
        else if (userGuess < numberToGuess) return GuessResult.TooLow;
        else return GuessResult.TooHigh;
    }
}

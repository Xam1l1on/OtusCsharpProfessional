using System;
namespace DemonstrationOfSolidPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUserInterface ui = new UserInterface();
            IRandomNumberGenerator random = new SimpleRandomNumberGenerator();
            IMessageProvider messageProvider = new DefaultMessageProvider();
            IGameLogic game = new GameLogic(ui, random, messageProvider);
            game.StartGame();
        }
    }
}

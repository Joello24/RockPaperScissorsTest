using System;

namespace RefactorDemoGroupProj
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleIO ui = new ConsoleIO();
            GameWorkflow RPSGame = new GameWorkflow(ui);
            RPSGame.Run();
        }
    
    }
}
using RefactorDemoGroupProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorDemoGroupProj
{
    internal class GameWorkflow
    {
        public static ConsoleIO UI;
        public GameWorkflow(ConsoleIO ui)
        {
            UI = ui;
        }
        public void Run()
        {
            bool isRunning = true;
            IChoice player1 = SetPlayer();
            IChoice player2 = SetPlayer();

            Console.WriteLine(GetResult(player1, player2));
        }
        public static int GetResult(IChoice player1, IChoice player2)
        {
            if (player1.GetResult == player2.GetResult)
            {
                return 1;
            }

            // player one win conditions
            if ((player1.GetResult() == Picker.ROCK && player2.GetResult() == Picker.SCISSORS) ||
                (player1.GetResult() == Picker.PAPER && player2.GetResult() == Picker.ROCK ||
                (player1.GetResult() == Picker.SCISSORS && player2.GetResult() == Picker.PAPER)))
            {
                return 2;
            }
            return 3;
        }
        public static IChoice SetPlayer()
        {
            bool isRunning = true;
            while (true)
            {
                switch (PlayerMenuSelect())
                {
                    case 1:
                        RandomPicker random = new RandomPicker();
                        return random;
                    case 2:
                        ConsolePicker console = new ConsolePicker();
                        return console;
                    case 3:
                        AlwaysPicksRock rock = new AlwaysPicksRock();
                        return rock;
                    case 4:
                        AlwaysPicksPaper paper = new AlwaysPicksPaper();
                        return paper;
                    case 5:
                        AlwaysPicksSciccors scissors = new AlwaysPicksSciccors();
                        return scissors;
                    default:
                        break;
                }
            }
        }
        private static int PlayerMenuSelect()
        {
            Console.WriteLine(@"
1. Random Picker
2. Console Picker
3. Always Rock
4. Always Paper
5. Always Scissors");
            return 
                ConsoleIO.GetInt("Enter implementation for player");
        }
    }
}

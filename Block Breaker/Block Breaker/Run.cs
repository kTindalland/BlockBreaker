using System;
using Block_Breaker.Menu.Displays;
using Block_Breaker.Menu.KeyGetters;
using Block_Breaker.Options.Exit;
using Block_Breaker.Options.Instructions;
using Block_Breaker.Options.Play;
using Block_Breaker.Options.Scoreboard;

namespace Block_Breaker
{
    internal class Run
    {
        private static void Main()
        {
            var finished = false; // Signals when the program should end

            Console.CursorVisible = false; // Makes the cursor invisible
            var display = new BasicDisplay(); // Chosen display
            var keyGetter = new KeyGetter(); // Chosen KeyGetter

            var options = new[] // Options to choose from
            {
                "Play",
                "Options",
                "Instructions",
                "Scoreboard",
                "Exit"
            };

            var mainMenu = new Menu.Menu(display, keyGetter); // New menu
            mainMenu.SetOptions(options); // Assign the options

            var instructions = new Instructions();
            var optionsObject = new Options.Options.Options();
            var game = new Play();
            var scoreboard = new Scoreboard();
            var exiter = new Exit();

            mainMenu.OptionSelected += instructions.OnOptionSelected;
            mainMenu.OptionSelected += optionsObject.OnOptionSelected;
            mainMenu.OptionSelected += game.OnOptionSelected;
            mainMenu.OptionSelected += scoreboard.OnOptionSelected;
            mainMenu.OptionSelected += exiter.OnOptionSelected;


            while (!finished) // Main program loop
            {
                mainMenu.GetSelection(); // Get selection
            }
            


        }
    }
}

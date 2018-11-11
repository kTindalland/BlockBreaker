using System;
using Block_Breaker.Menu.Displays;
using Block_Breaker.Menu.KeyGetters;

namespace Block_Breaker
{
    class Run
    {
        static void Main()
        {
            Console.CursorVisible = false;
            var display = new BasicDisplay();
            var keyGetter = new KeyGetter();

            string[] options = new[]
            {
                "Play",
                "Options",
                "Instructions",
                "Scoreboard",
                "Exit"
            };

            var mainMenu = new Menu.Menu(display, keyGetter);
            mainMenu.SetOptions(options);

            var userSelection = mainMenu.GetSelection();
        }
    }
}

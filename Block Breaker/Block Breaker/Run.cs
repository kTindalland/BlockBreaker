﻿using System;
using Block_Breaker.Menu.Displays;
using Block_Breaker.Menu.KeyGetters;

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

            var options = new[] // Options to choose from TODO: Refactor this into an enum
            {
                "Play",
                "Options",
                "Instructions",
                "Scoreboard",
                "Exit"
            };

            var mainMenu = new Menu.Menu(display, keyGetter); // New menu
            mainMenu.SetOptions(options); // Assign the options


            while (!finished) // Main program loop
            {
                var userSelection = mainMenu.GetSelection(); // Get selection
            }
            


        }
    }
}
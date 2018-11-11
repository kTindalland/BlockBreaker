using System;
using Block_Breaker.Menu.Interfaces;

namespace Block_Breaker.Menu.Displays
{
    public class BasicDisplay : IDisplay
    {
        public void Display(string[] options, int selectedOption)
        {
            Console.Clear();
            DrawTitle();
            DrawOptions(options, selectedOption);
        }

        /// <summary>
        /// Draws the title 3 lines from the top of the screen.
        /// </summary>
        private void DrawTitle()
        {
            var title = "Block Breaker";

            Console.CursorLeft = (Console.WindowWidth - title.Length) / 2; // Center the text
            Console.CursorTop += 3;

            Console.Write(title);

            Console.CursorTop += 2;
        }

        /// <summary>
        /// Draws all the options below the title, with the current selected one wrapped in brackets.
        /// </summary>
        /// <param name="options">The full list of options.</param>
        /// <param name="selectedOption">The index of the currently selected option.</param>
        private void DrawOptions(string[] options, int selectedOption)
        {
            for (int i = 0; i < options.Length; i++)
            {
                var currentOption = options[i];

                if (i == selectedOption) // if selected, wrap in brackets
                    currentOption = "[ " + currentOption + " ]";

                Console.CursorLeft = (Console.WindowWidth - currentOption.Length) / 2; // Center the text
                Console.CursorTop += 1;

                Console.Write(currentOption);
            }
        }
    }
}

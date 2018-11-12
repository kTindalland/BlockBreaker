using System;
using Block_Breaker.Options.Interfaces;
using Block_Breaker.Resources.EventArgs;

namespace Block_Breaker.Options.Play
{
    public class Play : IOption
    {
        public void OnOptionSelected(object sender, OptionSelectedEventArgs args)
        {
            if (args.ChosenOption == "Play")
                PlayGame();
        }

        private void PlayGame()
        {
            Console.Clear();

            Console.Write("Play Game :)");

            Console.ReadKey();
        }
    }
}

using System;
using Block_Breaker.Options.Interfaces;
using Block_Breaker.Resources.EventArgs;

namespace Block_Breaker.Options.Scoreboard
{
    public class Scoreboard : IOption
    {
        public void OnOptionSelected(object sender, OptionSelectedEventArgs args)
        {
            if (args.ChosenOption == "Scoreboard")
                ShowScoreboard();
        }

        private void ShowScoreboard()
        {
            Console.Clear();

            Console.Write("Scoreboard: test");

            Console.ReadKey();
        }
    }
}

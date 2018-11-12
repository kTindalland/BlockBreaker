using System;
using Block_Breaker.Options.Interfaces;
using Block_Breaker.Resources.EventArgs;

namespace Block_Breaker.Options.Options
{
    public class Options : IOption
    {
        public void OnOptionSelected(object sender, OptionSelectedEventArgs args)
        {
            if (args.ChosenOption == "Options")
                ShowOptions();
        }

        private void ShowOptions()
        {
            Console.Clear();

            Console.Write("Options: test");

            Console.ReadKey();
        }
    }
}

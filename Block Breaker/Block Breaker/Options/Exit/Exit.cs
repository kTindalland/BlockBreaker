using System;
using Block_Breaker.Options.Interfaces;
using Block_Breaker.Resources.EventArgs;

namespace Block_Breaker.Options.Exit
{
    public class Exit : IOption
    {
        public void OnOptionSelected(object sender, OptionSelectedEventArgs args)
        {
            if (args.ChosenOption == "Exit")
                ExitProg();
        }

        private void ExitProg()
        {
            Environment.Exit(0);
        }
    }
}

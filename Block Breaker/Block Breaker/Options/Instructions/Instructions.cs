using System;
using Block_Breaker.Options.Interfaces;
using Block_Breaker.Resources.EventArgs;

namespace Block_Breaker.Options.Instructions
{
    public class Instructions : IOption
    {
        public void OnOptionSelected(object sender, OptionSelectedEventArgs args)
        {
            if (args.ChosenOption == "Instructions")
                ShowInstructions();
        }

        private void ShowInstructions()
        {
            var lines = new[]
            {
                "The aim is to break as many blocks as you can with your ball.",
                "To win, hit the top of the screen with the ball.",
                "Hit as many blocks before that to increase your score!",
                "You lose if the ball hits the bottom of the screen.",
                "To prevent this, hit the ball back up with your paddle.",
                "To move your paddle, use the left and right arrow keys."
            };

            Console.Clear();

            Console.WriteLine("Instructions:");
            Console.CursorTop++;

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }


            Console.ReadKey(true);
        }
    }
}

using System;
using Block_Breaker.Menu.Interfaces;
using Block_Breaker.Resources.Enumerations;

namespace Block_Breaker.Menu.KeyGetters
{
    public class KeyGetter : IKeyGetter
    {
        public DisplayDirection GetDirection()
        {
            var key = Console.ReadKey(true).Key; // Get which key was pressed.

            switch (key) // Switch on what key was pressed.
            {
                case ConsoleKey.UpArrow:
                    return DisplayDirection.Up;

                case ConsoleKey.DownArrow:
                    return DisplayDirection.Down;

                case ConsoleKey.Enter:
                    return DisplayDirection.Select;

                default:
                    return DisplayDirection.Stay;
            }
        }
    }
}

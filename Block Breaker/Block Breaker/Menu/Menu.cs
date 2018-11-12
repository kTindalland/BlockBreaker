using System;
using Block_Breaker.Menu.Interfaces;
using Block_Breaker.Resources.Enumerations;

namespace Block_Breaker.Menu
{
    public class Menu : IMenu
    {
        private readonly IDisplay _display; // Display object.
        private readonly IKeyGetter _keyGetter; // KeyGetter object.
        private string[] _options; // List of options to choose from.
        private int _selectedOption; // Index of currently selected option.
        private bool _finished; // If the user has pressed enter.

        public Menu(IDisplay display, IKeyGetter keyGetter) // Dependency injection for testability.
        {
            _display = display;
            _keyGetter = keyGetter;
        }

        public void SetOptions(string[] options)
        {
            _options = options;
        }

        public string GetSelection()
        {
            _finished = false;
            while (!_finished) // Main loop
            {
                _display.Display(_options, _selectedOption); // Display the options.
                SwitchOnKey(); // Get key and choose what to do based on what was pressed.
            }

            return _options[_selectedOption];
        }

        /// <summary>
        /// Gets the key pressed and switches on what to do.
        /// </summary>
        private void SwitchOnKey()
        {
            switch (_keyGetter.GetDirection())
            {
                case DisplayDirection.Down:
                    _selectedOption++;
                    break;

                case DisplayDirection.Up:
                    _selectedOption--;
                    break;

                case DisplayDirection.Select:
                    _finished = true;
                    break;
            }

            ValidateSelectedOption();
        }

        /// <summary>
        /// Check to make sure that the selected option variable is valid; and if it isn't, make it valid.
        /// </summary>
        private void ValidateSelectedOption()
        {
            if (_selectedOption >= _options.Length)
                _selectedOption = 0;

            if (_selectedOption < 0)
                _selectedOption = _options.Length - 1;
        }
    }
}

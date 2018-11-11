using Block_Breaker.Menu.Interfaces;
using Block_Breaker.Resources.Enumerations;

namespace Block_Breaker.Menu
{
    public class Menu : IMenu
    {
        private readonly IDisplay _display;
        private readonly IKeyGetter _keyGetter;
        private string[] _options;
        private int _selectedOption;
        private bool _finished;

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
            while (!_finished)
            {
                _display.Display(_options, _selectedOption);
                SwitchOnKey();
            }

            return _options[_selectedOption];
        }

        /// <summary>
        /// Gets the key pressed and switches on what to do
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
        }
    }
}

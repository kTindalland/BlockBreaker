using Block_Breaker.Menu;
using Block_Breaker.Menu.Interfaces;
using Block_Breaker.Resources.Enumerations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlockBreaker.Tests.Menu_Tests
{
    [TestClass]
    public class MenuTests
    {
        [TestMethod]
        public void GetSelection_SelectFirstOption_ReturnFirstElementOfOptions()
        {
            var options = new[]
            {
                "First",
                "Second",
                "Third"
            };

            var display = new FakeDisplay();
            var keyGetter = new FakeKeyGetter();

            var menu = new Menu(display, keyGetter);
            menu.SetOptions(options);

            var userSelection = menu.GetSelection();

            Assert.AreEqual("First", userSelection);

        }

        [TestMethod]
        public void GetSelection_SelectSecondOption_ReturnSecondElementOfOptions()
        {
            var options = new[]
            {
                "First",
                "Second",
                "Third"
            };

            var display = new FakeDisplay();
            var keyGetter = new FakeKeyGetter();
            keyGetter.SetOptions(1, false);

            var menu = new Menu(display, keyGetter);
            menu.SetOptions(options);

            var userSelection = menu.GetSelection();

            Assert.AreEqual("Second", userSelection);
        }

        [TestMethod]
        public void GetSelection_LoopBackToEnd_ReturnThirdElementOfOptions()
        {
            var options = new[]
            {
                "First",
                "Second",
                "Third"
            };

            var display = new FakeDisplay();
            var keyGetter = new FakeKeyGetter();
            keyGetter.SetOptions(1, true);

            var menu = new Menu(display, keyGetter);
            menu.SetOptions(options);

            var userSelection = menu.GetSelection();

            Assert.AreEqual("Third", userSelection);
        }

        [TestMethod]
        public void GetSelection_LoopDownToStart_ReturnFirstElementOfOptions()
        {
            var options = new[]
            {
                "First",
                "Second",
                "Third"
            };

            var display = new FakeDisplay();
            var keyGetter = new FakeKeyGetter();
            keyGetter.SetOptions(3, false);

            var menu = new Menu(display, keyGetter);
            menu.SetOptions(options);

            var userSelection = menu.GetSelection();

            Assert.AreEqual("First", userSelection);
        }
    }

    class FakeDisplay : IDisplay
    {
        public void Display(string[] options, int selectedOption)
        {
            
        }
    }

    class FakeKeyGetter : IKeyGetter
    {
        private int _delay; // How many times it will move
        private bool _goUp; // If true it will move up, false will move down

        public DisplayDirection GetDirection()
        {
            var direction = DisplayDirection.Down;

            if (_goUp)
                direction = DisplayDirection.Up;

            if (_delay > 0)
            {
                _delay--;
                return direction;
            }
            else
            {
                return DisplayDirection.Select;
            }
        }

        public void SetOptions(int delay, bool goUp)
        {
            _delay = delay;
            _goUp = goUp;
        }
    }
}

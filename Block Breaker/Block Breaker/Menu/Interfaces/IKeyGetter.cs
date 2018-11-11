using Block_Breaker.Resources.Enumerations;

namespace Block_Breaker.Menu.Interfaces
{
    public interface IKeyGetter
    {
        DisplayDirection GetDirection(); // Will wait for a keypress and return which DisplayDirection it corresponds to
    }
}

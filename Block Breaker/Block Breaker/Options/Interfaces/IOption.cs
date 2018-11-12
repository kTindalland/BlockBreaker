using Block_Breaker.Resources.EventArgs;

namespace Block_Breaker.Options.Interfaces
{
    public interface IOption
    {
        void OnOptionSelected(object sender, OptionSelectedEventArgs args);
    }
}

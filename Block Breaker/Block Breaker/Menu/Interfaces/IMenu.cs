namespace Block_Breaker.Menu.Interfaces
{
    public interface IMenu
    {
        void SetOptions(string[] options); // Will set the array of options that will be displayed.
        string GetSelection(); // Will return which option the user selected.
    }
}

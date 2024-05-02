namespace Flashcardia.Components
{
    public class UserState
    {
        public UserState() { }
        public ApplicationUser? User { get; set; } = null;
        public Deck? SelectedDeck { get; set; } = null;
        public Card? SelectedCard { get; set; } = null;
    }
}

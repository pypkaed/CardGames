namespace Models.Cards.Implementations;

public class CardNine : Card
{
    private new const string Value = "Nine";
    
    public CardNine(CardSuit suit)
        : base(Value, suit)
    { }
}
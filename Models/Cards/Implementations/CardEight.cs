namespace Models.Cards.Implementations;

public class CardEight : Card
{
    private new const string Value = "Eight";

    public CardEight(CardSuit suit) 
        : base(Value, suit)
    { }
}
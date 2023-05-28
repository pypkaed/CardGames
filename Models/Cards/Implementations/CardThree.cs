namespace Models.Cards.Implementations;

public class CardThree : Card
{
    private new const string Value = "Three";

    public CardThree(CardSuit suit) 
        : base(Value, suit)
    { }
}
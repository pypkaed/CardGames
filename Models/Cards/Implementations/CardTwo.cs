namespace Models.Cards.Implementations;

public class CardTwo : Card
{
    private new const string Value = "Two";

    public CardTwo(CardSuit suit) 
        : base(Value, suit)
    { }
}
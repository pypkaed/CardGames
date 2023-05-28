namespace Models.Cards.Implementations;

public class CardSeven : Card
{
    private new const string Value = "Seven";

    public CardSeven(CardSuit suit)
        : base(Value, suit)
    { }
}
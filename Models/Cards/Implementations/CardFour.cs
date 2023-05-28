namespace Models.Cards.Implementations;

public class CardFour : Card
{
    private new const string Value = "Four";

    public CardFour(CardSuit suit)
        : base(Value, suit)
    { }
}
namespace Models.Cards.Implementations;

public class CardKing : Card
{
    private new const string Value = "King";

    public CardKing(CardSuit suit)
        : base(Value, suit)
    { }
}
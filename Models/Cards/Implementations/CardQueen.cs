namespace Models.Cards.Implementations;

public class CardQueen : Card
{
    private new const string Value = "Queen";

    public CardQueen(CardSuit suit)
        : base(Value, suit)
    { }
}
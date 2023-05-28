namespace Models.Cards.Implementations;

public class CardAce : Card
{
    private new const string Value = "Ace";

    public CardAce(CardSuit suit)
        : base(Value, suit)
    { }
}
namespace Models.Cards.Implementations;

public class CardFive : Card
{
    private new const string Value = "Five";

    public CardFive(CardSuit suit) 
        : base(Value, suit)
    { }
}
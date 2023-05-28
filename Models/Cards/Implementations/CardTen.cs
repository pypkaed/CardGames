namespace Models.Cards.Implementations;

public class CardTen : Card
{
    private new const string Value = "Ten";

    public CardTen(CardSuit suit) 
        : base(Value, suit)
    { }
}
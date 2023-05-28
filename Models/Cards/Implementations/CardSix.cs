namespace Models.Cards.Implementations;

public class CardSix : Card
{
    private new const string Value = "Six";

    public CardSix(CardSuit suit) 
        : base(Value, suit)
    { }
}
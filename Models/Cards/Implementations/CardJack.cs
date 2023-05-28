namespace Models.Cards.Implementations;

public class CardJack : Card
{
    private new const string Value = "Jack";

    public CardJack(CardSuit suit) 
        : base(Value, suit)
    { }
}
namespace Models.Cards;

public abstract class Card
{
    protected Card(
        string value,
        CardSuit suit)
    {
        Value = value;
        Suit = suit;
    }
    public string Value { get; }
    public CardSuit Suit { get; }

    public override string ToString()
    {
        return Value + " of " + Suit;
    }
}
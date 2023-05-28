using Models.Cards;

namespace Models;

public class CardDeck
{
    private readonly List<Card> _cards;

    public CardDeck()
    {
        _cards = new List<Card>();
    }

    public CardDeck(List<Card> cards)
    {
        _cards = cards;
    }
    
    public IReadOnlyList<Card> Cards => _cards;

    public void AddCard(Card card)
    {
        _cards.Add(card);
    }
    
    public void RemoveCard(Card card)
    {
        _cards.Remove(card);
    }

    public void Shuffle()
    {
        throw new NotImplementedException();
    }
}
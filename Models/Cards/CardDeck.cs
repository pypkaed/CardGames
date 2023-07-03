using Solitaire.Extensions;

namespace Models.Cards;

public class CardDeck
{
    private List<Card> _cards;

    public CardDeck()
    {
        _cards = new List<Card>();
    }

    public CardDeck(List<Card> cards)
    {
        _cards = cards;
    }
    
    public IEnumerable<Card> Cards => _cards;

    public void AddCard(Card card)
    {
        _cards.Add(card);
    }
    
    public void RemoveCard(Card card)
    {
        // TODO: add checks
        _cards.Remove(card);
    }

    public void Shuffle()
    {
        _cards = _cards.Shuffle().ToList();
    }

    public Card GetRandomCard()
    {
        throw new NotImplementedException();
    }

    public Card GetTopCard()
    {
        throw new NotImplementedException();
    }
    public Card GetBottomCard()
    {
        throw new NotImplementedException();
    }
}
using Models.Extensions;

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
    
    public IReadOnlyCollection<Card> Cards => _cards;

    public void AddCard(Card card)
    {
        _cards.Add(card);
    }
    
    public void RemoveCard(Card card)
    {
        if (!_cards.Contains(card)) throw new Exception("No such card");
        _cards.Remove(card);
    }

    public void Shuffle()
    {
        _cards = _cards.Shuffle().ToList();
    }

    public Card GetRandomCard()
    {
        return Cards.GetRandomElement();
    }

    public Card GetTopCard()
    {
        return Cards.First();
    }
    public Card GetBottomCard()
    {
        return Cards.Last();
    }
    public Card PopRandomCard()
    {
        var card = Cards.GetRandomElement();
        _cards.Remove(card);
        return card;
    }

    public Card PopTopCard()
    {
        var card = Cards.First();
        _cards.Remove(card);
        return card;
    }
    public Card PopBottomCard()
    {
        var card = Cards.Last();
        _cards.Remove(card);
        return card;
    }
}
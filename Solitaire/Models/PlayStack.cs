using Models.Cards;

namespace Solitaire.Models;

public class PlayStack
{
    private List<Card> _cards;
    public PlayStack()
    {
        _cards = new List<Card>();
    }
    
    public IReadOnlyCollection<Card> Cards => _cards;

    public void AddCard(Card card)
    {
        // TODO: add checks
        _cards.Add(card);
    }
}
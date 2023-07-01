using Models.Cards;

namespace Solitaire.Models;

public class WinStack
{
    private List<Card> _cards;
    public WinStack(CardSuit suit)
    {
        _cards = new List<Card>();
        
        CardSuit = suit;
    }
    
    public CardSuit CardSuit { get; }
    public IReadOnlyCollection<Card> Cards => _cards;

    public void AddCard(Card card)
    {
        // TODO: add checks
        _cards.Add(card);
    }
}
using Models.Cards;

namespace Solitaire.Models;

public class WinStack
{
    public WinStack(CardSuit suit)
    {
        CardSuit = suit;
    }
    
    public CardSuit CardSuit { get; }
}
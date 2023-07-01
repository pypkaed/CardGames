using Models.Cards;

namespace Solitaire.Config;

public class Constants
{
    public static readonly int PlayStacksNum = 7;
    
    public static readonly IEnumerable<CardSuit> Suits = new List<CardSuit>
    {
        CardSuit.Clubs,
        CardSuit.Diamonds,
        CardSuit.Hearts,
        CardSuit.Spades,
    };
}
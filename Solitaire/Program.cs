using Models.Cards;
using Models.Cards.Implementations;
using Solitaire.Models;

namespace Solitaire;

public class Program
{
    public static void Main()
    {
        var deck = InitializeSolitaireDeck();
        deck.Shuffle();

        var winStacks = InitializeWinStacks();
    }

    private static CardDeck InitializeSolitaireDeck()
    {
        var cards = new List<Card>();
        var suits = new List<CardSuit>
        {
            CardSuit.Clubs,
            CardSuit.Diamonds,
            CardSuit.Hearts,
            CardSuit.Spades,
        };

        foreach (var suit in suits)
        {
            cards.Add(new CardAce(suit));
            cards.Add(new CardTwo(suit));
            cards.Add(new CardThree(suit));
            cards.Add(new CardFour(suit));
            cards.Add(new CardFive(suit));
            cards.Add(new CardSix(suit));
            cards.Add(new CardSeven(suit));
            cards.Add(new CardEight(suit));
            cards.Add(new CardNine(suit));
            cards.Add(new CardTen(suit));
            cards.Add(new CardJack(suit));
            cards.Add(new CardQueen(suit));
            cards.Add(new CardKing(suit));
        }
        
        return new CardDeck(cards);
    }

    private static IEnumerable<WinStack> InitializeWinStacks()
    {
        var winStacks = new List<WinStack>();
        var suits = new List<CardSuit>
        {
            CardSuit.Clubs,
            CardSuit.Diamonds,
            CardSuit.Hearts,
            CardSuit.Spades,
        };
        
        foreach (var suit in suits)
        {
            winStacks.Add(new WinStack(suit));
        }

        return winStacks;
    }
}
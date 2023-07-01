using Models.Cards;
using Models.Cards.Implementations;
using Solitaire.Config;
using Solitaire.Models;

namespace Solitaire;

public class Program
{
    public static void Main()
    {
        var deck = InitializeSolitaireDeck();
        var winStacks = InitializeWinStacks();
        var playStacks = InitializePlayStacks();

        deck.Shuffle();
        
        // TODO: add cards to play stacks, remove from deck
    }

    private static CardDeck InitializeSolitaireDeck()
    {
        var cards = new List<Card>();

        foreach (var suit in Constants.Suits)
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

        foreach (var suit in Constants.Suits)
        {
            winStacks.Add(new WinStack(suit));
        }

        return winStacks;
    }

    private static IEnumerable<PlayStack> InitializePlayStacks()
    {
        var playStacks = new List<PlayStack>();
        
        for (int i = 0; i < Constants.PlayStacksNum; i++)
        {
            playStacks.Add(new PlayStack());
        }

        return playStacks;
    }
}
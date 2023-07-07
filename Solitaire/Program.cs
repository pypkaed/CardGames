using Models.Cards;
using Models.Cards.Implementations;
using Solitaire.Config;
using Solitaire.Models;

namespace Solitaire;

public class Program
{
    public static void Main()
    {
        // TODO: make a separate Game.cs class?
        var winStacks = InitializeWinStacks();
        var playStacks = InitializePlayStacks();
        
        var deck = FillSolitaireDeck();
        deck.Shuffle();

        FillPlayStacks(ref playStacks, ref deck);
    }

    private static CardDeck FillSolitaireDeck()
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

    private static void FillPlayStacks(ref IEnumerable<PlayStack> playStacks, ref CardDeck deck)
    {
        for (int i = 0; i < Constants.PlayStacksNum; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                var randomCard = deck.PopRandomCard();
                playStacks.ElementAt(i).AddCard(randomCard);
            }
        }
    }
}
namespace Solitaire.Extensions;

public static class ShuffleExtension
{
    private static readonly Random Rand = new Random();

    // this kinda sucks but oh well
    public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> input)
    {
        var inputList = input.ToList();
        var shuffledArray = new List<T>(inputList.Count);

        while (inputList.Count > 0)
        {
            int randomIndex = Rand.Next(inputList.Count);
            shuffledArray.Add(inputList[randomIndex]);
            inputList.RemoveAt(randomIndex);
        }

        return shuffledArray;
    }
}
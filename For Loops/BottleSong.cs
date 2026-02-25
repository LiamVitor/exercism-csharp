using System.Collections.Generic;

public static class BottleSong
{
    public static IEnumerable<string> Recite(int startBottles, int takeDown)
    {
        List<string> verses = new List<string>();

        for (int i = 0; i < takeDown; i++)
        {
            int numberOfBottles = startBottles - i;

            verses.Add($"{getNumberName(numberOfBottles)} green {plural(numberOfBottles)} hanging on the wall,");
            verses.Add($"{getNumberName(numberOfBottles)} green {plural(numberOfBottles)} hanging on the wall,");

            verses.Add($"And if one green bottle should accidentally fall,");

            if (numberOfBottles == 1)
            {
                verses.Add($"There'll be no green bottles hanging on the wall.");
            }
            else
                verses.Add($"There'll be {getNumberName(numberOfBottles - 1).ToLower()} green {plural(numberOfBottles - 1)} hanging on the wall.");

            if (takeDown != i + 1)
            {
                verses.Add("");
            }
        }
        return verses;
    }

    public static string getNumberName(int number) => number switch
    {
        1 => "One",
        2 => "Two",
        3 => "Three",
        4 => "Four",
        5 => "Five",
        6 => "Six",
        7 => "Seven",
        8 => "Eigth",
        9 => "Nine",
        10 => "Ten",
    };

    public static string plural(int number) => number == 1 ? "bottle" : "bottles";
}
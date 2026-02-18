public static class ResistorColorDuo
{
    public static int ColorCode(string color) => Array.IndexOf(Colors(), color);

    public static string[] Colors() => new string[]{
        "black", "brown", "red", "orange", "yellow",
        "green", "blue", "violet", "grey", "white",
    };

    public static int Value(string[] colors)
    {
        var sb = new StringBuilder();

        for (int index = 0; index < 2; index++)
        {
            sb.Append(ColorCode(colors[index]).ToString());
        }
        return Convert.ToInt32(sb.ToString());
    }
}

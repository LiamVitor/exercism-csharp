public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        if (subjects.Length == 0) return [];

        List<string> sb = new List<string>();

        for (int index = 0; index < subjects.Length - 1; index++)
        {
            sb.Add($"For want of a {subjects[index]} the {subjects[index + 1]} was lost.");
        }

        sb.Add($"And all for the want of a {subjects[0]}.");

        return sb.ToArray();
    }
}
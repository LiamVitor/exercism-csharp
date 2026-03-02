public static class Bob
{
    public static string Response(string statement)
    {
        bool screaming = isScreaming(statement);
        bool silence = haveSilence(statement);

        if (statement.Trim().EndsWith('?'))
        {
            return screaming ? "Calm down, I know what I'm doing!" : "Sure.";
        }

        if (silence) return "Fine. Be that way!";

        if (screaming) return "Whoa, chill out!";

        return "Whatever.";
    }

    public static bool haveSilence(string statement)
    {
        int sequence = 0;
        string newStatement = statement.Trim();

        if (newStatement.Equals("")) return true;

        for (int i = 0; i < newStatement.Length; i++)
        {
            if (newStatement[i].Equals(' ') || Char.IsControl(newStatement[i]))
            {
                sequence++;
                if (sequence == 2) return true;
            }
            else sequence = 0;
        }

        return false;
    }

    public static bool isScreaming(string statement)
    {
        int capitalLetters = 0;
        int numberOfLetters = statement.Where(x => Char.IsLetter(x)).Count();

        if (numberOfLetters == 0) return false;

        for (int i = 0; i < statement.Length; i++)
        {
            if (Char.IsUpper(statement[i]) && Char.IsLetter(statement[i]))
            {
                capitalLetters++;
            }
        }

        return capitalLetters == numberOfLetters;
    }
}
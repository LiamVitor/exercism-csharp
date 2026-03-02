public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        char[] character = text.ToCharArray();
        List<char> newText = new List<char>();

        int maxLetterNumber;
        int minLetterNumber;

        for (int index = 0; index < character.Length; index++)
        {
            if (Char.IsUpper(character[index]))
            {
                maxLetterNumber = (int)'Z';
                minLetterNumber = (int)'A';
            }
            else
            {
                maxLetterNumber = (int)'z';
                minLetterNumber = (int)'a';
            }

            if (character[index].Equals(' ') || Char.IsNumber(character[index]) || Char.IsPunctuation(character[index]))
            {
                newText.Add(character[index]);
                continue;
            }

            if (character[index] + shiftKey > maxLetterNumber)
            {
                newText.Add((char)(((character[index] + shiftKey) - (maxLetterNumber + 1)) + minLetterNumber));
                continue;
            }

            newText.Add((char)(text[index] + shiftKey));
        }

        return new string(newText.ToArray());
    }
}
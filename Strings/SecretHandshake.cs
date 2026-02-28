public static class SecretHandshake
{
    public static int[] ConvertDecimaToBinary(int number)
    {
        int divisor = number;

        List<int> binary = new List<int>();

        while (divisor > 0)
        {
            int rest = divisor % 2;
            divisor /= 2;

            binary.Add(rest);
        }
        return binary.ToArray();
    }

    public static string[] Commands(int commandValue)
    {
        var binaryNumber = ConvertDecimalToBinary(commandValue);
        List<string> secretSequence = new List<string>();

        Dictionary<int, string> handshakeActions = new Dictionary<int, string>
        {
            {0, "wink"},
            {1, "double blink"},
            {2, "close your eyes"},
            {3, "jump"},
        };

        for (int index = 0; index < binaryNumber.Length; index++)
        {
            if (index == 4 && binaryNumber[index] == 1)
            {
                secretSequence.Reverse();
                break;
            }

            if (binaryNumber[index] == 1)
            {
                secretSequence.Add(handshakeActions.GetValueOrDefault(index));
            }
        }

        return secretSequence.ToArray();
    }
}
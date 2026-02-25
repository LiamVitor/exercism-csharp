public static class EliudsEggs
{
    public static int EggCount(int encodedCount)
    {
        int divisor = encodedCount;

        List<int> binary = new List<int>();

        while (divisor > 2)
        {
            int resto = divisor % 2;
            divisor /= 2;

            binary.Add(resto);
        }

        binary.Reverse();

        return binary.Where(x => x == 1).Count;
    }
}

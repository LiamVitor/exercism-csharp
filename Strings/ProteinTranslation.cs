public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        var condons = new List<string>();
        var proteins = new List<string>();
        var condonMap = new Dictionary<string, string>()
        {
            { "AUG", "Methionine" },
            { "UUU", "Phenylalanine" },
            { "UUC", "Phenylalanine" },
            { "UUA", "Leucine" },
            { "UUG", "Leucine" },
            { "UCU", "Serine" },
            { "UCC", "Serine" },
            { "UCA", "Serine" },
            { "UCG", "Serine" },
            { "UAU", "Tyrosine" },
            { "UAC", "Tyrosine" },
            { "UGU", "Cysteine" },
            { "UGC", "Cysteine" },
            { "UGG", "Tryptophan" }
        };

        for (int index = 0; index < strand.Length; index += 3)
        {
            condons.Add(strand.Substring(index, 3));
        }

        var codonEnumerator = condons.GetEnumerator();

        while (codonEnumerator.MoveNext())
        {
            if (!condonMap.ContainsKey(codonEnumerator.Current)) return proteins.ToArray();

            proteins.Add(condonMap.GetValueOrDefault(codonEnumerator.Current));
        }

        return proteins.ToArray();
    }
}
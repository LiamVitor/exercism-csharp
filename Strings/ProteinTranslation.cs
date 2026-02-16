/*
    Contexto da questão:
    O exercício propõe a tradução de sequências de RNA em proteínas,
    seguindo a regra biológica de que cada grupo de três nucleotídeos
    (códon) corresponde a um aminoácido específico.

    Estratégia utilizada:
    Foi utilizado um dicionário para mapear cada códon ao seu respectivo
    aminoácido, pois essa estrutura de dados oferece acesso rápido e direto
    às informações. A string de entrada é dividida em substrings de três
    caracteres, permitindo a validação e tradução sequencial de cada códon.
*/
public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        var codons = new List<string>();
        var proteins = new List<string>();

        /*
            Dicionário que associa cada códon conhecido ao seu
            respectivo aminoácido. Essa abordagem melhora a legibilidade
            do código e torna a busca mais eficiente em comparação com
            múltiplas estruturas condicionais. 
        */
        var codonMap = new Dictionary<string, string>()
        {
            { "AUG", "Methionine"   },
            { "UUU", "Phenylalanine"},
            { "UUC", "Phenylalanine"},
            { "UUA", "Leucine"      },
            { "UUG", "Leucine"      },
            { "UCU", "Serine"       },
            { "UCC", "Serine"       },
            { "UCA", "Serine"       },
            { "UCG", "Serine"       },
            { "UAU", "Tyrosine"     },
            { "UAC", "Tyrosine"     },
            { "UGU", "Cysteine"     },
            { "UGC", "Cysteine"     },
            { "UGG", "Tryptophan"   }
        };

        /*
            Loop responsável por dividir a sequência de RNA em blocos
            de três caracteres e adicioná-los à lista de códons.
        */
        for (int index = 0; index < strand.Length; index += 3)
        {
            codons.Add(strand.Substring(index, 3));
        }

        var codonEnumerator = codons.GetEnumerator();

        /*
            Percorre cada códon extraído e verifica se ele existe no dicionário.
            Caso o códon não seja reconhecido, a tradução é interrompida e os
            aminoácidos já obtidos são retornados.
        */
        while (codonEnumerator.MoveNext())
        {
            if (!codonMap.ContainsKey(codonEnumerator.Current))
                return proteins.ToArray();

            proteins.Add(codonMap.GetValueOrDefault(codonEnumerator.Current));
        }

        return proteins.ToArray();
    }
}
/*
    O uso de dicionários é especialmente vantajoso em cenários como este,
    onde há uma relação direta entre chaves e valores bem definidos.
    Eles permitem buscas eficientes, tornam o código mais organizado
    e facilitam a manutenção e extensão da lógica.

    Como complemento, será disponibilizado um conteúdo adicional abordando
    o conceito de dicionários.
*/
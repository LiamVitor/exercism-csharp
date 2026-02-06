/*
    Exercício com foco no aprimoramento do uso de funções nativas das estruturas
    string e char, além da prática com laços de repetição aplicados à lógica de 
    programação.

    Conceitos abordados neste exercício:
    - Manipulação de strings
    - Uso do tipo char
    - Laços de repetição (for)
*/
public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        // Percorre cada caractere da palavra
        for (int currentCharIndex = 0; currentCharIndex < word.Length; currentCharIndex++)
        {
            // Ignora qualquer caractere que não seja uma letra como "-" ou " "
            if (!Char.IsLetter(word[currentCharIndex])) continue;

            // Compara o caractere atual com os próximos caracteres da string
            for (int comparisonIndex = currentCharIndex + 1; comparisonIndex < word.Length; comparisonIndex++)
            {
                // Ignora novamente caracteres que não sejam letras para evitar comparações desnecessárias
                if (!Char.IsLetter(word[comparisonIndex])) continue;

                // Compara os dois caracteres ignorando diferenças entre letras maiúsculas e minúsculas
                if (string.Equals(char.ToString(word[currentCharIndex]), char.ToString(word[comparisonIndex]), StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }
        }
        return true;
    }
}
/*
    Questões como esta são ótimas para aprimorar a lógica de programação.
    Neste exercício, busquei trabalhar da forma mais eficiente possível,
    evitando comparações desnecessárias e mantendo o código legível.

    A solução prioriza clareza e entendimento da lógica, mesmo utilizando
    uma abordagem de complexidade O(n²), adequada ao contexto didático
    da proposta.
*/
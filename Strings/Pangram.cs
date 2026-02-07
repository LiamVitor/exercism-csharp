/*
    Exercício explora o uso de funções nativas para manipulação de strings
    e caracteres, além da aplicação de laços de repetição para percorrer
    e validar a presença de cada letra do alfabeto na string de entrada.

    Conceitos abordados neste exercício:
    - Manipulação de strings
    - Laços de repetição (for)
*/
using System.Text;
public static class Pangram
{
    public static bool IsPangram(string input)
    {
        // Encerra a execução caso a string de entrada seja nula ou vazia
        if (string.IsNullOrEmpty(input)) return false;

        // String que representa todas as letras do alfabeto
        string alfabeto = "abcdefghijklmnopqrstuvwxyz";

        // Percorre cada caractere da string
        for (int currentCharIndex = 0; currentCharIndex < input.Length; currentCharIndex++)
        {
            /*
                Verifica se o caractere atual existe no alfabeto, 
                desconsiderando diferenças entre maiúsculas e minúsculas
            */
            if (alfabeto.Contains(input[currentCharIndex], StringComparison.OrdinalIgnoreCase))
            {
                /*
                    Remove do alfabeto a letra correspondente ao caractere encontrado,
                    garantindo que cada letra seja contabilizada apenas uma vez
                */
                alfabeto = alfabeto.Remove(alfabeto.IndexOf(input[currentCharIndex], StringComparison.OrdinalIgnoreCase), 1);
            }
        }
        /* 
            Se todas as letras do alfabeto foram removidas,
            a string de entrada é considerada um pangrama 
        */
        return string.IsNullOrEmpty(alfabeto) ? true : false;
    }
}

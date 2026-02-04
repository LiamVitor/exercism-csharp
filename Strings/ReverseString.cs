/*
    Exercício com foco na prática de manipulação de strings
    e no desenvolvimento da lógica de programação.

    O objetivo é explorar diferentes abordagens para inverter
    uma string, analisando legibilidade, desempenho e uso de
    recursos da linguagem.
*/
public static class ReverseString
{

    // Retorna a string de entrada invertida utilizando um laço manual (for).
    public static string Reverse(string input)
    {
        string output = "";
        for (int X = input.Length - 1; X >= 0; X--)
        {
            output += input[X];
        }
        return output;
    }

    // Retorna o reverso da string de entrada utilizando a classe StringBuilder 
    public static string ReverseStringWithStringBuilder(string input)
    {
        var sb = new StringBuilder(input.Length);
        for (int X = input.Length - 1; X >= 0; X--)
        {
            sb.Append(input[X]);
        }
        return Convert.ToString(sb);
    }

    //Retorna o reverso da string de entrada convertendo-a para um array de caracteres
    public static string ReverseStringWithArray(string input)
    {
        char[] output = input.ToCharArray();
        Array.Reverse(output);
        return Convert.ToString(output);
    }
}
/*
    Cada método apresentado demonstra uma abordagem diferente para inverter
    uma string em C#. Existem diversas formas de realizar essa operação
    (pelo menos sete abordagens comuns), e neste exercício foram exploradas
    três delas: duas implementadas manualmente e uma utilizando um método
    nativo da linguagem.

    acho que para todos a primeira soluçãoque costuma surgir é o uso de um laço 
    manual (for), percorrendo a string de trás para frente e concatenando os 
    caracteres em uma nova variável do tipo string. Apesar de simples e 
    intuitiva, essa abordagem não é eficiente, pois strings em C# são 
    imutáveis, o que causa a criação de múltiplos objetos na memória a cada 
    concatenação.

    Uma alternativa mais performática é o uso do StringBuilder, que é
    mutável e foi projetado especificamente para cenários com múltiplas
    operações de concatenação, reduzindo o custo de memória e processamento.

    Por fim, a abordagem mais eficiente e legível apresentada utiliza o
    método nativo Array.Reverse(), que opera diretamente sobre um array
    de caracteres, invertendo seus elementos de forma "in-place" (sem
    criar um novo array). Após a inversão, o array é convertido novamente
    para string, combinando clareza de código e bom desempenho.
*/
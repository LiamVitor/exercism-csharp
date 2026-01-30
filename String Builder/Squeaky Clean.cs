/*
    Esse exercicio tem como objetivo ensinar pra ensinar 2 topicos muito 
    importantes quando falamos sobre manipulação de strings, que são a Classe 
    StringBuilder e funções ultilitarias de Char.
    A questão simula o processo de normalização/limpeza de identificadores, um 
    processo comum em sistemas que precisam transformar entradas "sujas" em 
    nomes válidos e consistentes para uso interno no código.

    Conceitos dessa questão: 
    - StringBuilder Class
    - Char
*/
using System.Text;
using System.Globalization;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var sb = new StringBuilder(identifier.Length); // Inicializa a sb como uma variavel da classe StringBuilder com tamanho de identifier

        // Percorre cada caractere do identificador original
        for (int digitNumber = 0; digitNumber < identifier.Length; digitNumber++)
        {
            char digit = identifier[digitNumber]; // Caractere atual sendo analisado

            if (digit.Equals(' ')) sb.Append('_'); // Remove espaços vazios e coloca "_"

            if (Char.IsControl(digit)) sb.Append("CTRL"); // Substitui caracteres de controle por "CTRL"

            if (digit.Equals('-')) // Verifica se o digito é "-", adiciona o proximo digito em maiusculo 
            {
                sb.Append(Char.ToUpper(identifier[digitNumber + 1], CultureInfo.InvariantCulture));
                digitNumber++;
            }

            // Retorna uma caractere vazio com tres condicoes especificas, se for um numero, se é qualquer digito que 
            // não seja uma letra e diferente de "_" e se o digito estiver entre o digitos listados entre "α" to "ω" 
            if (Char.IsNumber(digit) || ((!Char.IsLetter(digit) && identifier[digitNumber] != '_') || (digit >= 'α' && digit <= 'ω')))
            {
                sb.Append(string.Empty);
            }
            else sb.Append(identifier[digitNumber]);

            /* 
                Você pode se perguntar sobre o porque que o uso de varios ifs no 
                codigo, pode ate parececer algo redundante mas nesse caso é presciso
                por causa de alguns casos que se aplicam a mais de uma regra
            */
        }
        return sb.ToString();
    }
}
/*
    As strings nada mais são que uma sequencia de caracteres, como se fosse um 
    array de chars, nos conseguimos observar isso em linguagens mais antigas como
    C onde faziamos exatamente isso. 

    Em C# as strings são imutaveis, oque quer 
    dizer que uma vez que elas são criadas elas não podem ser alteradas, quando 
    a modificamos o computador não altera a original, ele cria uma nova string 
    totalmente diferente no lugar.

    Já as StringsBuilders são mutaveis, ou seja, você quando as altera, o 
    computador não cria nada novo para substituir a velha string, e isso se deve 
    pelo fato de que as StringBuilders são classe utilitarias de C# projetadas
    para cria e manipular sequencia de caracteres de forma dinamica e mutavel

    A classe StringBuilder possui varias funções que ajudam a fazer a 
    manipulações das strings, será criado um arquivo como material complementar
    falando sobre essas funcões
*/
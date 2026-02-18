/*
    Contexto do exercício:
    Este exercício possui um contexto semelhante ao da questão ResistorColor,
    porém aqui é necessário analisar mais de uma faixa de cor. O objetivo é
    interpretar as duas primeiras cores de um resistor e retornar o valor
    numérico correspondente à combinação dessas cores.

    Estratégia aplicada:
    A solução utiliza um array fixo que define a ordem das cores e seus
    respectivos valores numéricos, onde o índice de cada cor representa
    diretamente o seu código.
    
    Para obter o valor final do resistor, são consideradas apenas as duas
    primeiras cores do array de entrada. Cada cor é convertida em seu valor
    numérico e concatenada como texto utilizando um StringBuilder. Ao final,
    a string resultante é convertida para inteiro, representando o valor do
    resistor.
*/
public static class ResistorColorDuo
{
    // Retorna o código numérico de uma cor com base na sua posição no array
    public static int ColorCode(string color) => Array.IndexOf(Colors(), color);

    // Define a ordem padrão das cores do código de resistores
    public static string[] Colors() => new string[]{
        "black", "brown", "red", "orange", "yellow",
        "green", "blue", "violet", "grey", "white",
    };

    // Calcula o valor do resistor a partir das duas primeiras cores informadas
    public static int Value(string[] colors)
    {
        // StringBuilder é utilizado para evitar múltiplas concatenações de string
        var sb = new StringBuilder();

        for (int index = 0; index < 2; index++)
        {
            sb.Append(ColorCode(colors[index]).ToString());
        }
        return Convert.ToInt32(sb.ToString());
    }
}

/*
    Contexto do exercício:
    O exercício simula um sistema de identificação de resistores, semelhante ao
    utilizado em plataformas como o Raspberry Pi, onde cada faixa de cor possui
    um valor numérico associado.

    Estratégia aplicada:
    As cores são armazenadas em um array ordenado, onde o índice de cada posição
    representa diretamente o valor numérico da cor. O método Array.IndexOf é
    utilizado para localizar a posição da cor informada e retornar seu valor.
*/
public static class ResistorColor
{
    // Retorna o valor numérico correspondente à cor informada
    public static int ColorCode(string color) => Array.IndexOf(Colors(), color);

    // Retorna a lista de cores disponíveis, ordenadas conforme o padrão do sistema
    public static string[] Colors() => new string[]{
        "black", "brown", "red", "orange", "yellow",
        "green", "blue", "violet", "grey", "white",
    };
}
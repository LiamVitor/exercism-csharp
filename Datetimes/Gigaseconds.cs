/*
    Contexto do exercício:
    O objetivo é calcular a data e a hora exatas que ocorrem um gigassegundo
    após uma data inicial fornecida.

    Estratégia aplicada:
    Utiliza-se o método nativo AddSeconds da struct DateTime para somar
    1.000.000.000 (um bilhão) de segundos ao instante informado, garantindo
    simplicidade, legibilidade e precisão no cálculo.
*/
public static class Gigasecond
{
    // Retorna a data e hora resultantes da adição de um gigassegundo ao momento informado
    public static DateTime Add(DateTime moment) => moment.AddSeconds(1_000_000_000);
}
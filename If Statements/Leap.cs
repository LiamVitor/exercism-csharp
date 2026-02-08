/*
    Exercício voltado à prática do uso de operadores e estruturas
    condicionais. A proposta consiste em simular uma função responsável
    por determinar se um determinado ano é bissexto.
*/
public static class Leap
{
    public static bool IsLeapYear(int year) => (year % 100 != 0 && year % 400 == 0) || year % 4 == 0;

    public static bool IsLeapYear(int year)
    {
        if (year % 100 == 0)
        {
            return year % 400 == 0 ? true : false;
        }

        return year % 4 == 0 ? true : false;
    }

    public static bool IsLeapYear(int year) => year % 100 == 0 ?
        year % 400 == 0 ? true : false
        :
        year % 4 == 0 ? true : false;
}
/*
    As implementações resolvem corretamente o problema do
    cálculo de ano bissexto, porém com abordagens distintas.

    A primeira versão prioriza concisão, utilizando uma expressão
    booleana direta, enquanto a segunda favorece legibilidade,
    manutenibilidade e facilidade de depuração ao explicitar
    o fluxo da regra com estruturas condicionais.

    A última implementação demonstra o uso de operadores ternários
    aninhados, válida do ponto de vista funcional, mas menos indicada
    em cenários onde clareza e manutenção do código são prioridades.

    O objetivo do exercício não é definir uma única forma "correta",
    mas compreender os impactos de cada abordagem na leitura,
    manutenção e evolução do código
*/
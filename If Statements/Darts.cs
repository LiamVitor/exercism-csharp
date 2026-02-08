/*
    Exercício focado na aplicação de conceitos matemáticos aliados
    ao uso de estruturas condicionais. A proposta simula uma função
    responsável por calcular, a partir das coordenadas em um plano
    cartesiano, se um dardo atingiu o alvo e qual a pontuação obtida.
*/
public static class Darts
{
    public static int Score(double x, double y)
    {
        double local = (x * x) + (x * x);

        double innerCircle = 1;
        double middleCircle = 5 * 5;
        double OuterCircle = 10 * 10;

        if (local <= innerCircle)
            return 10;
        if (local <= middleCircle)
            return 5;
        if (local <= OuterCircle)
            return 1;
        return 0;
    }
}
/*
    Inicialmente, este tipo de problema costuma ser resolvido utilizando
    condições explícitas do tipo "maior que X e menor ou igual a Y".
    Essa abordagem é correta e muito importante no aprendizado da lógica
    de programação.

    Nesta solução, ultilizei uma abordagem mais enxuta, onde as condições
    são avaliadas de forma sequencial. Como cada verificação anterior já
    filtra parte dos casos, não é necessário repetir comparações de limite
    inferior em todas as estruturas condicionais, essa simplificação não altera 
    a lógica do algoritmo, apenas aproveita melhor o fluxo do código para 
    reduzir redundâncias, melhorar a legibilidade e facilitar a manutenção.
*/
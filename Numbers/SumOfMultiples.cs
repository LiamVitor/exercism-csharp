/*
    Exercício com foco na prática do uso de operadores e estruturas de repetição,
    incentivando também a utilização de LINQ para criar soluções mais declarativas
    e concisas.

    A questão simula o cálculo de pontos de energia concedidos aos jogadores ao
    completar um nível, somando todos os múltiplos de determinados valores até
    um limite máximo.
*/
public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        return multiples
            .Where(n => n != 0)
            // Filtra valores inválidos, evitando divisão por zero 

            .SelectMany(m => Enumerable.Range(1, (max - 1) / m)
                // Gera uma sequência de 1 até o maior número possível

                .Select(x => x * m))
            // Para cada valor gerado no Range, multiplica por "m"

            .Distinct()
            // Remove valores duplicados

            .Sum();
        // Soma todos os múltiplos únicos encontrados.
    }
}

/*
    Com a utilização do LINQ, o código perde muita verbosidade em comparação
    a uma abordagem imperativa tradicional com loops aninhados e listas auxiliares.

    A solução se torna mais declarativa, focando no "o que deve ser feito"
    (filtrar, projetar, achatar, remover duplicados e somar) em vez do
    "como fazer" passo a passo.

    Essa abordagem melhora a legibilidade, reduz código repetitivo e facilita
    a manutenção, além de incentivar o pensamento funcional dentro do C#.
*/

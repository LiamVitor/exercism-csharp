/*
    Contexto da questão:
    O exercicio procura descobrir qual é a raiz quadradada exata de um numero 
    inteiro 

    Estratégia utilizada:
    1. Geramos uma sequência de números primos.
    2. Fatoramos o número original (radicando) em fatores primos.
    3. Agrupamos os fatores em pares iguais (quadrados perfeitos).
    4. Multiplicamos um elemento de cada par para obter a raiz quadrada.
*/
public static class SquareRoot
{
    public static int Root(int number)
    {
        int radicand = number;

        // Lista que armazena todos os divisores primos do radicando
        List<int> primedivisors = new List<int>();

        /* 
            Gera números primos no intervalo de 2 a 20
            A lógica considera primo o número que possui apenas dois divisores: 
            1 e ele mesmo
        */
        var primeNumbers = Enumerable.Range(2, 20)
            .Where(x => Enumerable.Range(2, x)
                .Where(y => x % y == 0)
                .Count() == 1)
            .GetEnumerator();

        /*
            Fatora o radicando dividindo sucessivamente pelos números primos
            Cada divisor encontrado é armazenado na lista
        */
        while (primeNumbers.MoveNext())
        {
            while (radicand % primeNumbers.Current == 0)
            {
                primedivisors.Add(primeNumbers.Current);
                radicand /= primeNumbers.Current;
            }

            // Interrompe a fatoração quando o número é totalmente reduzido
            if (radicand == 1)
                break;
        }

        int result = 1;

        /*
            Agrupa os fatores primos em pares, apenas pares com valores iguais 
            representam quadrados perfeitos
        */
        var productOfPairs = primedivisors.Chunk(2)
            .Where(x => x[0] == x[1])
            .Select(x => x[0])
            .GetEnumerator();

        /*
            Multiplica cada fator extraído dos pares, O produto final 
            corresponde à raiz quadrada exata
        */
        while (productOfPairs.MoveNext())
        {
            result *= productOfPairs.Current;
        }

        return result;
    }
}

/*
    a variavel do tipo var permite que o compilador infira automaticamente
    o tipo da variável com base no valor atribuído a ela no momento da
    declaração.

    Apesar de var simplificar a escrita do código e reduzir verbosidade,
    o tipo da variável continua sendo fortemente tipado e definido em
    tempo de compilação. Ou seja, var não torna a variável dinâmica.

    Seu uso é recomendado quando o tipo é evidente pelo contexto,
    como em expressões LINQ ou quando o tipo concreto é longo ou complexo,
    melhorando a legibilidade do código.
*/
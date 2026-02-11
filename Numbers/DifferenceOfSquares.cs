/*
    Exercicio com foco na pratica em exercitar logica com Loops, operadores e a 
    decomposiçao de problemas. A questao simula funcoes matematicas como o 
    quadrado da soma e a soma dos quadrados.
*/
public static class DifferenceOfSquares
{
    /*
        Calcula o quadrado da soma
        Implementação imperativa utilizando loop for
    */
    public static int CalculateSquareOfSum(int max)
    {
        int naturalNumber = 0;
        for (int x = 1; x <= max; x++)
        {
            naturalNumber += x;
        }
        return naturalNumber * naturalNumber;

    }

    /*
        Calcula o quadrado da soma 
        Implementação declarativa utilizando LINQ para reduzir código
    */
    public static int CalculateSquareOfSum(int max)
    {
        return Math.Pow(List.Range(1, max).Sum(), 2);
    }

    /*
        Calcula a soma dos quadrados dos números naturais de 1 até max
        Implementação matemática direta, sem iteração
    */
    public static int CalculateSumOfSquares(int max) => max * (max + 1) * (2 * max + 1) / 6;

    /*
        Calcula a soma dos quadrados dos números naturais de 1 até max
        Implementação utilizando LINQ com projeção (Select)
    */
    public static int CalculateSumOfSquares(int max)
    {
        return Enumerable.Range(1, max).Select(x => x * x).Sum();
    }

    // Retorna a diferença entre a soma dos quadrado e o quadrado da soma
    public static int CalculateDifferenceOfSquares(int max) =>
        CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}
/*
    Nessa questão trouxe duas formas diferentes de implementar as funções principais:
    uma abordagem utilizando métodos convencionais, com loops e operadores, e outra
    utilizando LINQ.

    O uso de LINQ introduz um estilo declarativo de programação, no qual operações como
    Select e Sum são aplicadas diretamente sobre coleções. Essa abordagem reduz código
    repetitivo, melhora a legibilidade e facilita a expressão da lógica, especialmente
    em cenários de transformação e agregação de dados.

    Para utilizar LINQ, é necessário trabalhar com coleções ou com estruturas que
    implementem IEnumerable, como listas ou sequências geradas pela classe Enumerable,
    que permite criar e manipular conjuntos de dados sem a necessidade de loops
    explícitos.

    Em C#, também existe a classe Math, voltada exclusivamente para operações
    matemáticas, como potenciação e outros cálculos comuns. O uso dessa classe
    contribui para um código mais claro, reutilizável e alinhado às funcionalidades
    nativas da linguagem.

    Como complemento a este exercício, serão adicionados materiais extras abordando
    com mais profundidade o uso de LINQ e da classe Math
*/

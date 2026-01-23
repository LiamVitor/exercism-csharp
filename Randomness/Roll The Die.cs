/*
    Esse exercicio exercicio tem como objetivo apresentar a classe de 
    randomização em C#. A questão simula rolagem de um dado em um contexto de 
    jogo

    Conceitos nessa questão:
    - Classe de Randomização
*/
public class Player
{
    // Instancia da classe Random
    System.Random Rng = new System.Random();

    // Retorna um numero entre 1 e 18
    public int RollDie() => Rng.Next(1, 19);

    // Retorna um numero de ponto flutuante Double entre 1 e 100
    public double GenerateSpellStrength() => Rng.NextDouble() * 100;
}
/*
    A classe de randomização basicamente é um gerador de numeros pseudoaleatorios
    oque significa que ele não gera numero realmente randomicos, mas sim numeros
    baseados em algoritmos matematicos 
    Os metodos principais da classe Random são o .Next() e .NextDouble(), elas 
    trabalham com o mesmo objetivo, gerar um numero aleatorio, mas, de formas 
    diferentes

    - O .Next() gera um numero inteiro em um intervalo de numeros expecificado
    esse metodo recebe dois parametros, um valor minimo e um valor maximo.

    Normalmente, somamos +1 ao valor máximo desejado porque o limite superior é 
    exclusivo, o que significa que o valor minimo está incluído, mas o valor maximo 
    serve apenas como a fronteira que o sorteio não pode atingir.

    - O NextDouble() já é diferente, ele vai gerar um numero double entre 0 e 1
    porem ele segue a mesma regra do .Next(), 0 é o valor minimo incluido e o 1
    é exclusivo e serve apenas como um limite.

    Algo que vale mencionar é que a Classe Random trabalha com Sementes ou Seeds
    essas sementes funcionam como um ponto de partida matematico para gerar os numeros
    uma forma boa de se entender essas sementes é que se intanciarmos duas classes
    Random com a mesma semente, a sequencia de numeros pseudoaleatorio vao ser as 
    mesmas 

    Random rng1 = new Random(42);
    Random rng2 = new Random(42);

    Console.WriteLine(rng1.Next()); // 12345
    Console.WriteLine(rng2.Next()); // 12345 (mesmo valor)    
*/
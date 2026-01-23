/*
    O exercício tem como objetivo praticar o uso de estruturas condicionais (if), 
    conversão de tipos (casting) e operações com valores numéricos inteiros e 
    ponto flutuante. O problema simula a análise da produção de uma linha de 
    montagem de automóveis, levando em consideração a velocidade de operação e a 
    taxa de sucesso em cada nível.
    
    Conceitos nessa questão:
    - Estrutura condicionais 
    - Conversão de tipos
    - Variáveis inteiras, float e double
*/
static class AssemblyLine
{
    public static int CarsPerHour = 221; // Quantidade de carros produzidos por hora

    // Retorna a chance de sucesso de acordo com a velocidade de produção
    public static double SuccessRate(int speed)
    {
        if (speed == 10) return 0.77;
        if (speed == 9) return 0.8;
        if (speed >= 5 && speed <= 8) return 0.9;
        if (speed >= 1 && speed <= 4) return 1;
        return 0;
    }

    // Calcula a taxa de produção por hora levando em consideração a velocidade e a chance de sucesso
    public static double ProductionRatePerHour(int speed) => (CarsPerHour * speed) * SuccessRate(speed);

    // Retorna a quantidade de carros produzidos por minuto em uma hora
    public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;
}

/*
    Nesta questão é nos apresentado algo muito importante para nós, programadores
    em C#, que é justamente a conversão de tipos, afinal a depender do programa 
    iremos trabalhar com diversos tipos de dados o tempo todo.
    Nós temos 2 tipos principais de conversão de tipos:

    - implícito:
        Ocorre quando um valor de um tipo menor é atribuído a um tipo maior,
        sem risco de perda de informação. Nesse caso, o próprio C# realiza
        a conversão automaticamente. 
        
            int numeroInt = 100;
            double numeroDouble = numeroInt;
            Console.WriteLine(numeroDouble); // saida:100 

    - explicíto:
        Ocorre quando um valor de um tipo maior é convertido para um tipo menor.
        Como pode haver perda de informação, essa conversão exige uma autorização
        explicíta do programador.

            double numeroDouble = 9.69;
            int numeroInt = (int)numeroDouble;
            Console.WriteLine(numeroInt); //saida:9;

    Cada tipo de dado ocupa um espaço diferente na memória, o que explica a
    necessidade dessas regras. Alguns exemplos de tamanhos em C#:

    - int -> 4 bytes 
    - long -> 8 bytes
    - float -> 4 bytes
    - double -> 8 bytes
    - decimal -> 16 bytes
    - char -> 2 bytes
    - bool -> 1 byte

    Estes são so alguns de muitos tipos que C# possui.
*/
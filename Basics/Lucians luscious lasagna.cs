/*
    O exercício tem como objetivo praticar o uso de métodos, retorno 
    de valores e operações básicas em C#, simulando o tempo de preparo 
    de uma lasanha. 

    Conceitos desta questão:
    -Métodos
    -Tipos primitivos (int, bool, etc)
    -Retorno de valores
    -Operações matemáticas
*/

class Lasagna
{
    public int OvenTime = 40;   // Tempo estimado de forno

    public int TimePrepare = 2; // Tempo em que cada camada é preparada 

    //Método que retorna o tempo estimado de forno 
    public int ExpectedMinutesInOven() => OvenTime;

    /*
        Recebe o tempo de forno que a lasanha já está no forno e 
        retorna o tempo que falta para ficar pronta 
    */
    public int RemainingMinutesInOven(int Time) => OvenTime - Time;

    /*
        Recebe a quantidade de camada que a lasanha possui e 
        retorna o tempo para prepará-la
    */
    public int PreparationTimeInMinutes(int LayersNumber)
    {
        return TimePrepare * LayersNumber;
    }

    //Método que calcula o tempo total com o preparo e tempo de forno da lasanha
    public int ElapsedTimeInMinutes(int LayersNumber, int Time)
    {
        return PreparationTimeInMinutes(LayersNumber) + Time;
    }
}

/* 
    Um ponto interessante que aprendi respondendo esta questão é o uso
    do operador da seta lambda "=>"
    esse operador substitui a definição do escopo da função ({}) e do 
    return 
    Mas, obviamente, isso não é aplicável o tempo todo, possui modos corretos 
    de usar, sendo eles:

        -O método tem apenas uma linha
        -Ele só retorna um valor ou uma pequena expressão
        -Não precisa de lógica complexa (if, loops, etc.)

    Onde pode ser usado?

        -Propriedades
        -Construtores
        -Getters
        -Overrides simples
        -Operadores

    é algo que considero totalmente recomendado, deixa o codigo mais limpo e legível. 
*/
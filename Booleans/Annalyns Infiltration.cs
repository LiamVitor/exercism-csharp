/*
    O exercício tem como objetivo a prática dos operadores booleanos, expressões lógicas
    e reforço ao uso de métodos e ao retorno de valores, simulando a lógica de 
    missões de um jogo RPG.

    Conceitos desta questão:
    -Operadores booleanos
    -Tipos primitivos (int, bool, etc)
    -Retorno de valores
*/

static class QuestLogic
{
    // Retorna true se o cavaleiro não estiver acordado
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;

    // Retorna true se pelo menos um dos membros estiver acordado
    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => knightIsAwake || archerIsAwake || prisonerIsAwake;

    // Retorna true se o arqueiro estiver dormindo e o prisioneiro acordado
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => !archerIsAwake && prisonerIsAwake;

    /*
        Retorna true se for possível libertar o prisioneiro:
        - com cachorro: arqueiro deve estar dormindo
        - sem cachorro: arqueiro e cavaleiro devem estar dormindo  
    */
    public static bool CanFreePrisoner(
        bool knightIsAwake,
        bool archerIsAwake,
        bool prisonerIsAwake,
        bool petDogIsPresent
    ) =>
        (petDogIsPresent && !archerIsAwake) ||
        (prisonerIsAwake && !knightIsAwake && !archerIsAwake);
}

/*
    Quando li o que a questão pedia, foi intuitivo utilizar estruturas 
    condicionais, como o if, no meu código, o que funcionou corretamente.
    Porém, esse não era o foco do exercício. O objetivo principal era praticar o
    uso direto dos operadores lógicos, sem depender de condicionais.
    Isso ampliou minha compreensão sobre como utilizar operadores lógicos de 
    forma mais clara e eficiente.
    Acho que algo fundamental a se falar desde o inicio, para toda pessoa que 
    está aprendendo a programar em C#, é justamente sobre os C# coding conventions
    regras oficiais da própria microsoft para padronização de código e legibilidade
    Estudar e aplicar essas convenções desde o início é fundamental para 
    desenvolver boas práticas, escrever código mais organizado e facilitar a 
    leitura e manutenção no futuro.
*/
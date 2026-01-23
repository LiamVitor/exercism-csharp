/*
    Este exercício tem como finalidade a prática de estruturas de repetição 
    (do-while) e o reforço do uso de operações com valores numéricos de ponto 
    flutuante, juntamente com a conversão de tipos. O objetivo é simular o 
    funcionamento básico de uma conta poupança bancária.

    Conceitos desta questão:
    - Estrutura de repetição(do-while)
    - Variáveis float, double e decimal
    - Conversão de tipos
*/
static class SavingsAccount
{
    // Determina a taxa de juros com base no saldo
    public static float InterestRate(decimal balance)
    {
        if (balance >= 5000)
        {
            return 2.475f;
        }
        else if (balance >= 1000 && balance < 5000)
        {
            return 1.621f;
        }
        else if (balance < 1000 && balance >= 0)
        {
            return 0.5f;
        }
        else return 3.213f;
    }

    // Calcula os juros com base no saldo
    public static decimal Interest(decimal balance) => balance * ((decimal)InterestRate(balance) / 100);

    // Soma o redimento dos juros ao saldo original anualmente  
    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    // Define o número mínimo de anos para alcançar o valor desejado com base no saldo
    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int Count = 0;
        decimal TotalBalance = balance;
        do
        {
            if (TotalBalance < targetBalance)
            {
                Count++;
            }
            TotalBalance = AnnualBalanceUpdate(TotalBalance);
        } while (TotalBalance < targetBalance);
        return Count;

    }
}
/*
    Neste exercício é apresentado o uso da estrutura de repetição do-while
    que garante a execução do bloco de código ao menos uma vez antes da
    verificação da condição. Essa característica é ideal para situações em
    que um cálculo inicial precisa ser realizado, como a atualização anual
    de um saldo bancário.

    Além do do-while, a linguagem C# possue outras três estruturas de
    repetição, cada uma indicada para diferentes cenários:

    - while: 
        executa o bloco de código enquanto a condição for verdadeira,
        sendo indicada quando não há garantia de que a repetição precise
        ocorrer ao menos uma vez

    - for: 
        utilizada quando a quantidade de iterações é conhecida ou pode
        ser controlada por um contador, sendo comum em laços baseados em
        índices

    - foreach: 
        aplicada para percorrer coleções, como arrays e listas,
        iterando diretamente sobre seus elementos
*/
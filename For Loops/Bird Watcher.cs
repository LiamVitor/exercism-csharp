/*
    Este exercício tem como objetivo apresentar dois conceitos muito importante 
    quando falamos de estrutura de dados: for loop e o array ou matriz.
    tambem permite praticar os conceitos básicos de Programação Orientada a 
    Objetos por meio da criação e uso de uma classe.

    Conceitos praticados neste exercício:
    - Arrays (ou matrizes)
    - Estrutura de repetição (for e foreach)
    - Classes e objetos
*/
class BirdCount
{
    private int[] _birdsPerDay; //Array da quantidade de passaros para cada dia da semana
    public int[] _lastWeekCountBird = new int[] { 0, 2, 5, 3, 7, 8, 4 }; // Array da quantidade de passaros da semana passada, para cada dia da semena

    // Construtor da classe BirdCount
    public BirdCount(int[] birdsPerDay)
    {
        this._birdsPerDay = birdsPerDay;
    }
    // Retorna a quantidade de passaros da semana passada, para cada dia da semena
    public static int[] LastWeek()
    {
        var birdCount = new BirdCount(new int[7]);
        return birdCount._lastWeekCountBird;
    }

    // Retorna a quantidade de passaros do dia atual 
    public int Today() => _birdsPerDay[_birdsPerDay.Length - 1];

    // Adiciona um a contagem de passaros do dia atual
    public void IncrementTodaysCount()
    {
        _birdsPerDay[_birdsPerDay.Length - 1]++;
    }

    // Verifica se não teve visitas de passaros hoje
    public bool HasDayWithoutBirds()
    {
        foreach (int numbersBirds in _birdsPerDay)
        {
            if (numbersBirds == 0)
            {
                return true;
            }
        }
        return false;
    }

    // retorna a soma total de passaros do inicio da semana em uma quantidade de dias
    public int CountForFirstDays(int numberOfDays)
    {
        int countBirds = 0;
        for (int days = 0; days < numberOfDays; days++)
        {
            countBirds += _birdsPerDay[days];
        }
        return countBirds;
    }

    /// Retorana a soma total dos dia que forem movimentados ou seja maior do que cinco
    public int BusyDays()
    {
        int countBusyDays = 0;
        foreach (int numbersBirds in _birdsPerDay)
        {
            if (numbersBirds >= 5)
            {
                countBusyDays++;
            }
        }
        return countBusyDays;
    }
}
/*
    Nesta questão acabei não ultilizando a estrutura de repetição for e isso tem
    um motivo, primeiro vamos falar sobre a sintaxe dessa estrutura:

    for (inicialização; condição; incremento/iteração)
    {
        // Código a ser executado em cada repetição
    }            

    Essa é a forma como utilizamos o for loop, mas com que finalidade?
    De forma simples, o for é uma estrutura de repetição normalmente usada
    quando precisamos acessar posições específicas de um array ou controlar
    exatamente a quantidade de iterações realizadas.

    Já o foreach é mais indicado quando o objetivo é apenas percorrer todos
    os elementos da coleção, sem a necessidade de trabalhar diretamente com
    os índices. Como nesta questão o foco está na verificação e análise dos
    valores armazenados, e não no índice em si, o uso do foreach torna o código
    mais simples e legível.
*/
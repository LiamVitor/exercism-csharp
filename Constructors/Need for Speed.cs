/*
    Exercício responsável por aprimorar o conhecimento em Orientação a Objetos,
    introduzindo o uso de construtores de classe e a modelagem de comportamento
    por meio de métodos.

    Conceitos desta questão:
    - Classes
    - Construtores de classe
*/

// Classe que representa um carro de controle remoto 
class RemoteControlCar
{
    public int speed; // Quantidade em metros percorrida a cada chamada de Drive() 
    public int batteryDrain; // Quantidade de bateria drenada a cada chamada de Drive()
    public int batteryCharge = 100; // Bateria total do carrinho
    public int distance; //distancia percorrida pelo carrinho

    // Construtor da classe
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    // Retorna true quando a carga atual da bateria é insuficiente
    public bool BatteryDrained() => this.batteryCharge < this.batteryDrain ? true : false;

    // Retorna a distancia total percorrida pelo carrinho
    public int DistanceDriven() => this.distance;

    /*
        Move o carro uma vez, aumentando a distância percorrida
        e reduzindo a bateria, desde que haja carga suficiente
    */
    public void Drive()
    {
        if (!BatteryDrained())
        {
            this.distance += speed;
            this.batteryCharge -= batteryDrain;
        }
    }

    /* 
        Cria um carro especial "Nitro", com valores pré-definidos,
        simulando um modelo mais rápido com maior consumo de batria
    */
    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

// Classe que representa uma pista de corrida
class RaceTrack
{
    public int raceTrackSize; // Tamanho total da pista de corrida

    // Construtor da classe da pista
    public RaceTrack(int raceTrackSize)
    {
        this.raceTrackSize = raceTrackSize;
    }

    /*
        O carro tenta completar a pista dirigindo enquanto houver bateria.
        Se em algum momento a distância percorrida alcançar ou ultrapassar
        o tamanho da pista, a corrida é vencida.
    */
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();
            if (car.distance >= this.raceTrackSize)
            {
                return true;
            }
        }
        return false;
    }
}
/*
    Os construtores são muito importantes quando falamos de linguagens orientadas
    a objetos, pois são responsáveis por criar (instanciar) objetos a partir de
    uma classe específica.

    Como exemplo, temos a própria classe RemoteControlCar, que possui um método
    com o mesmo nome da classe. Esse método é chamado de construtor e é executado
    automaticamente no momento em que um novo objeto é criado.

    Sua principal função é inicializar os atributos da classe, garantindo que o
    objeto comece sua vida em um estado válido e pronto para uso.
*/
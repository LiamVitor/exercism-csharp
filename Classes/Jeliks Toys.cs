/*
    O exercício tem como objetivo reforçar os conceitos de orientação a objetos 
    e a manipulação de strings.

    Conceitos abordados nesta questão:
    - Classes e objetos
    - Manipulação de strings
*/
class RemoteControlCar
{
    private int _distanceTotal; // Armazena a distancia total percorrida pelo carro 
    private int _batteryCharge = 100; // Armazena a quantidade total de bateria 

    // Retorna uma nova instancia da classe RemoteControlCar
    public static RemoteControlCar Buy() => new RemoteControlCar();

    // Retorna uma string informando a quantidade total percorrida
    public string DistanceDisplay() => $"Driven {_distanceTotal} meters";

    // Retorna uma string informando o restante da bateria 
    public string BatteryDisplay()
    {
        if (_batteryCharge == 0) return "Battery empty";
        return $"Battery at {_batteryCharge}%";
    }

    /*
        Simula o movimento do carro:
        a cada chamada, aumenta a distância percorrida
        e reduz a carga da bateria, se ainda houver bateria disponível
    */
    public void Drive()
    {
        if (_batteryCharge > 0)
        {
            _distanceTotal += 20;
            _batteryCharge--;
        }
    }
}
/*
    A orientação a objetos é um dos pilares do C# e se baseia na ideia
    de representar conceitos do mundo real por meio de classes e objetos.
    Cada objeto possui estado e comportamento,permitindo organizar e estruturar 
    melhor o código.
    
    Como material complementar, foi criado um arquivo Markdown explicando melhor 
    sobre alguns pontos importantes sobre a orientação a objetos 
*/
/*
    Contexto da questão:
    O exercício calcula a idade de uma pessoa em diferentes planetas
    com base na quantidade de segundos vividos.

    Estratégia aplicada:
    A solução converte inicialmente os segundos para anos terrestres
    e, em seguida, utiliza o período orbital relativo de cada planeta
    para determinar a idade correspondente.

*/
public class SpaceAge
{
    private const double EarthYearInSeconds = 31_557_600;
    private double seconds;

    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth() => seconds / EarthYearInSeconds;

    public double OnMercury() => OnEarth() / 0.2408467;
    public double OnVenus() => OnEarth() / 0.61519726;
    public double OnMars() => OnEarth() / 1.8808158;
    public double OnJupiter() => OnEarth() / 11.862615;
    public double OnSaturn() => OnEarth() / 29.447498;
    public double OnUranus() => OnEarth() / 84.016846;
    public double OnNeptune() => OnEarth() / 164.79132;
}
/*
    O uso da palavra-chave const é importante quando trabalhamos
    com valores que são invariáveis e conhecidos em tempo de compilação.

    Neste exercício, EarthYearInSeconds representa um valor fixo
    (31.557.600 segundos), que nunca sofrerá alteração durante a execução
    do programa. Por isso, utilizar const é a escolha correta.

    Deve-se usar const quando:
    - O valor é fixo e universal
    - Não depende de instância
    - Não será alterado em nenhum cenário
*/
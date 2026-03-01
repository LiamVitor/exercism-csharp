/* 
    Contexto do exercício:
    O exercício simula um sistema de contagem de ovos a partir de um número
    codificado. Esse número representa, em formato binário, a quantidade de
    ovos presentes, onde cada bit 1 indica a presença de um ovo e cada bit 0
    indica ausência.

    Estratégia aplicada:
    O número decimal informado é convertido manualmente para binário por meio
    de divisões sucessivas por 2, armazenando os restos (0 ou 1) em uma lista.
    Após a conversão, é realizada a contagem dos valores iguais a 1, que
    representam diretamente a quantidade total de ovos.
*/
*/
public static class EliudsEggs
{
    public static int EggCount(int encodedCount)
    {
        // Variável auxiliar para realizar as divisões sucessivas
        int divisor = encodedCount;

        // Lista para armazenar os bits (0 ou 1) da conversão para binário
        List<int> binary = new List<int>();

        // Enquanto o número for maior que 1 ele vai executar a fatoração
        while (divisor > 1)
        {
            int resto = divisor % 2;
            divisor /= 2;

            binary.Add(resto);
        }

        // Inverte a lista para organizar os bits na ordem correta
        binary.Reverse();

        // Conta quantos bits 1 existem na lista
        return binary.Where(x => x == 1).Count;
    }
}
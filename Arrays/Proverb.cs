/*
    Contexto do exercício:
    O exercício testa sua capacidade de gerar texto encadeado a partir de uma 
    lista, respeitando dependências entre elementos e regras específicas de 
    formatação.

    Estratégia aplicada:
    A solução percorre o array de assuntos de forma sequencial, criando uma
    frase para cada par de elementos consecutivos. Para isso, o loop itera até
    o penúltimo item do array, evitando acessos fora do limite ao utilizar o
    índice atual junto ao próximo índice.
    
    Após a criação das frases intermediárias, é adicionada uma frase final
    que encerra o provérbio, sempre fazendo referência ao primeiro elemento
    da lista. Também é tratado o caso especial em que o array está vazio,
    retornando imediatamente um resultado vazio.
*/
public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        if (subjects.Length == 0) return [];

        // Lista usada para construir dinamicamente as frases do provérbio
        List<string> phrases = new List<string>();

        /*
            O loop percorre até subjects.Length - 1 para:
            - Garantir que sempre exista um próximo elemento (index + 1)
            - Evitar exceções de acesso fora dos limites do array
            - Impedir que o loop execute quando houver apenas um item
        */
        for (int index = 0; index < subjects.Length - 1; index++)
        {
            phrase.Add($"For want of a {subjects[index]} the {subjects[index + 1]} was lost.");
        }

        // Frase final que conclui o provérbio, sempre baseada no primeiro elemento
        phrase.Add($"And all for the want of a {subjects[0]}.");

        return phrase.ToArray();
    }
}
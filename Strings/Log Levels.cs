/*
    Este exercício tem como objetivo apresentar a classe string e suas
    funcionalidades. A questão simula o processamento de linhas de log,
    extraindo informações como mensagem e nível de registro.

    Conceitos nessa questão:
    - Classe string 
    - Manipulação de strings
*/
static class LogLine
{
    // Retorna a mensagem do log, removendo o nível e os espaços em branco no início e no final
    public static string Message(string logLine) => logLine.Remove(0, logLine.IndexOf(':') + 1).Trim();

    // Retorna somente o nivel da massagem em minusculo 
    public static string LogLevel(string logLine) => logLine.Remove(logLine.IndexOf(':')).Trim('[', ']').ToLower();

    // Retorna a Mensagem de log agora com o nivel no final da mensagem em minusculo e entre parenteses 
    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
/*
    Este exercício aborda apenas um subconjunto das funcionalidades da classe
    string, com foco em operações básicas de extração e formatação de texto.
    Apesar da simplicidade, ele demonstra como o encadeamento de métodos pode
    resolver problemas reais de forma clara e eficiente.
    
    Como material complementar, foi criado um arquivo Markdown contendo um
    resumo das principais funções da classe string em C#.
*/
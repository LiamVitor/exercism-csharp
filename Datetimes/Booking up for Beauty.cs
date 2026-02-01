/*
    Exercicio de apresentação aos principais conceitos
    relacionados à manipulação de datas e horas, algo extremamente comum
    em sistemas reais, como agendamentos, compromissos, eventos e prazos.

    Conceitos desta Questão: 
    - DateTime
*/
static class Appointment
{
    // Converte uma string com uma representação de uma data para o tipo DateTime
    public static DateTime Schedule(string appointmentDateDescription) => Convert.ToDateTime(appointmentDateDescription);

    // Verifica se o compromisso já ocorreu em relação à data e hora atuais
    public static bool HasPassed(DateTime appointmentDate) => DateTime.Now >= appointmentDate ? true : false;

    // Verifica se o compromisso é no periodo da tarde entre o intervalo de 12 as 18
    public static bool IsAfternoonAppointment(DateTime appointmentDate) => (appointmentDate.Hour >= 12 && appointmentDate.Hour < 18) ? true : false;

    // Retorna uma String informando um compromisso com um DateTime formatado em padrão EUA
    public static string Description(DateTime appointmentDate) => "You have an appointment on " + appointmentDate.ToString("M/d/yyyy h:mm:ss tt") + ".";

    // Retorna a data do aniversário anual, fixada em 15 de setembro do ano atual.
    public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, 9, 15);
}
/*
    O DateTime é uma struct fundamental do ecossistema .NET, utilizada para
    representar e manipular datas e horas de forma precisa e performática.

    Ele é implementado como struct porque representa um valor imutável na prática,
    ou seja, operações realizadas sobre um DateTime retornam novas instâncias,
    e não alteram o valor original.

    Como material complementar, foi criado um arquivo Markdown explicando
    algumas funcionalidades importantes da struct DateTime e seus principais usos.
*/
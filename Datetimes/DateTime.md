## Propriedades

- **`Year`**  
  Retorna o ano representado pelo objeto `DateTime`.

- **`Month`**  
  Retorna o mês (1 a 12).

- **`Day`**  
  Retorna o dia do mês.

- **`Hour`**  
  Retorna a hora (0 a 23).

- **`Minute`**  
  Retorna o minuto.

- **`Second`**  
  Retorna o segundo.

- **`Millisecond`**  
  Retorna os milissegundos.

- **`DayOfWeek`**  
  Retorna o dia da semana (`Sunday` a `Saturday`).

- **`DayOfYear`**  
  Retorna o dia do ano (1 a 366).

- **`Date`**  
  Retorna apenas a parte da data, com o horário definido como 00:00:00.

- **`TimeOfDay`**  
  Retorna um `TimeSpan` representando apenas o horário.

- **`Kind`**  
  Indica se o `DateTime` é `Local`, `Utc` ou `Unspecified`.

## Propriedades estáticas

- **`Now`**  
  Retorna a data e hora atuais do sistema (horário local).

- **`UtcNow`**  
  Retorna a data e hora atuais em UTC.

- **`Today`**  
  Retorna a data atual com o horário definido como 00:00:00.

- **`MinValue`**  
  Representa a menor data possível (`01/01/0001`).

- **`MaxValue`**  
  Representa a maior data possível (`31/12/9999`).

## Métodos de criação e conversão

- **`Parse()`**  
  Converte uma string em `DateTime`, considerando o formato cultural atual.

- **`ParseExact()`**  
  Converte uma string em `DateTime` exigindo um formato específico.

- **`TryParse()`**  
  Tenta converter uma string em `DateTime`, retornando `true` ou `false`.

- **`TryParseExact()`**  
  Tenta converter uma string em `DateTime` com formato específico.

- **`ToString()`**  
  Converte o `DateTime` em string, com ou sem formatação personalizada.

- **`ToUniversalTime()`**  
  Converte o valor atual para UTC.

- **`ToLocalTime()`**  
  Converte o valor atual para o horário local.

## Métodos de manipulação de datas e horas

- **`AddDays()`**  
  Retorna um novo `DateTime` adicionando dias.

- **`AddMonths()`**  
  Retorna um novo `DateTime` adicionando meses.

- **`AddYears()`**  
  Retorna um novo `DateTime` adicionando anos.

- **`AddHours()`**  
  Retorna um novo `DateTime` adicionando horas.

- **`AddMinutes()`**  
  Retorna um novo `DateTime` adicionando minutos.

- **`AddSeconds()`**  
  Retorna um novo `DateTime` adicionando segundos.

- **`AddMilliseconds()`**  
  Retorna um novo `DateTime` adicionando milissegundos.

- **`AddTicks()`**  
  Retorna um novo `DateTime` adicionando ticks (100 nanosegundos).

- **`Add()`**  
  Adiciona um `TimeSpan` ao `DateTime`.

## Métodos de comparação

- **`Compare()`**  
  Método estático que compara dois `DateTime`:
  - `0` se forem iguais
  - valor negativo se o primeiro for anterior
  - valor positivo se o primeiro for posterior

- **`CompareTo()`**  
  Compara o `DateTime` atual com outro.

- **`Equals()`**  
  Verifica se dois valores `DateTime` são iguais.

## Métodos de verificação

- **`IsDaylightSavingTime()`**  
  Indica se o `DateTime` está em horário de verão.

- **`IsLeapYear()`**  
  Método estático que verifica se um ano é bissexto.

## Métodos relacionados a intervalos de tempo

- **`Subtract()`**  
  Retorna um `TimeSpan` representando a diferença entre dois `DateTime`.
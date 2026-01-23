
### Propriedade
-   **`Length`**  
    Retorna um número inteiro que representa a quantidade total de caracteres presentes em uma string.
    
### Métodos de verificação
-   **`Contains()`**  
    Verifica se uma sequência de caracteres (substring) existe dentro da string, retornando `true` ou `false`.
-   **`StartsWith()`**  
    Verifica se a string começa com uma sequência específica de caracteres.
-   **`EndsWith()`**  
    Verifica se a string termina com uma sequência específica de caracteres.
-   **`Equals()`**  
    Compara se o conteúdo de duas strings é exatamente igual.
-   **`IsNullOrEmpty()`**  
    Verifica se a string é `null` ou vazia.
-   **`IsNullOrWhiteSpace()`**  
    Verifica se a string é `null`, vazia ou contém apenas caracteres de espaço em branco.
    
### Métodos de busca
-   **`IndexOf()`**  
    Retorna o índice da primeira ocorrência de um caractere ou substring. Retorna `-1` se não encontrar.
-   **`LastIndexOf()`**  
    Retorna o índice da última ocorrência de um caractere ou substring na string.

### Métodos de manipulação

-   **`Substring()`**  
    Extrai uma parte da string a partir de um índice específico, com comprimento opcional.
-   **`Replace()`**  
    Substitui todas as ocorrências de um caractere ou substring por outro valor informado.
-   **`Split()`**  
    Divide a string em um array de substrings com base em um delimitador.
-   **`Insert()`**  
    Insere uma string ou caractere em uma posição específica da string original.
-   **`Remove()`**  
    Remove um número determinado de caracteres a partir de um índice específico.
-   **`Concat()`**  
    Concatena duas ou mais strings ou objetos, gerando uma nova string.

### Métodos de formatação
-   **`Trim()`**  
    Remove espaços em branco (ou caracteres específicos) do início e do fim da string.
-   **`TrimStart()`**  
    Remove espaços em branco apenas do início da string.
-   **`TrimEnd()`**  
    Remove espaços em branco apenas do final da string.
-   **`PadLeft()`**  
    Preenche o início da string até atingir um comprimento total definido.
-   **`PadRight()`**  
    Preenche o final da string até atingir um comprimento total definido.
-   **`ToUpper()`**  
    Converte todos os caracteres da string para letras maiúsculas.
-   **`ToLower()`**  
    Converte todos os caracteres da string para letras minúsculas.
-   **`Format()`**  
    Cria uma string formatada utilizando marcadores de posição (`{0}`, `{1}`, etc.).

### Métodos de comparação
-   **`Compare()`**  
    Método estático que compara duas strings e retorna:
    -   `0` se forem iguais
    -   valor negativo se a primeira for menor
    -   valor positivo se a primeira for maior
-   **`CompareTo()`**  
    Compara a string atual com outra, retornando a ordem relativa entre elas.
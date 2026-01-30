### Propriedade

* **`Length`**
  Retorna ou define a quantidade atual de caracteres contidos no objeto `StringBuilder`.

---

### Métodos de adição

* **`Append()`**
  Adiciona uma string, caractere, número ou objeto ao final do conteúdo atual.
* **`AppendLine()`**
  Adiciona uma string seguida de uma quebra de linha ao final do conteúdo.
* **`AppendFormat()`**
  Adiciona uma string formatada utilizando marcadores de posição (`{0}`, `{1}`, etc.).
* **`AppendJoin()`**
  Concatena elementos de uma coleção ou array utilizando um separador, adicionando o resultado ao `StringBuilder`.

---

### Métodos de inserção

* **`Insert()`**
  Insere uma string ou valor em uma posição específica dentro do `StringBuilder`.

---

### Métodos de remoção

* **`Remove()`**
  Remove uma quantidade definida de caracteres a partir de um índice informado.
* **`Clear()`**
  Remove todo o conteúdo do `StringBuilder`, mantendo a instância reutilizável.

---

### Métodos de substituição

* **`Replace()`**
  Substitui todas as ocorrências de um caractere ou substring por outro valor.

---

### Métodos de conversão

* **`ToString()`**
  Converte o conteúdo atual do `StringBuilder` em uma string (`String`).

---

### Métodos de capacidade

* **`Capacity`**
  Retorna ou define a capacidade máxima de caracteres que o `StringBuilder` pode armazenar sem realocação de memória.
* **`EnsureCapacity()`**
  Garante que o `StringBuilder` tenha, no mínimo, a capacidade especificada.

---

### Métodos de cópia

* **`CopyTo()`**
  Copia um intervalo de caracteres do `StringBuilder` para um array de caracteres.

---

### Indexador

* **`this[int index]`**
  Permite acessar ou modificar diretamente um caractere em uma posição específica do `StringBuilder`.

---

### Métodos herdados de `Object`

* **`Equals()`**
  Verifica se duas instâncias de `StringBuilder` referenciam o mesmo objeto em memória (não compara o conteúdo).
* **`GetHashCode()`**
  Retorna o código hash da instância, herdado de `Object`.
* **`GetType()`**
  Retorna o tipo da instância em tempo de execução.

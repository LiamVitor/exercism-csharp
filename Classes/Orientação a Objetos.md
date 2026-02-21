# Classes em C# – Conceitos Fundamentais e Estrutura

Este material apresenta, de forma didática e organizada, os conceitos básicos 
de **Orientação a Objetos (OO)** em **C#**, abordando:

* O que é uma classe
* Como uma classe é estruturada
* Suas responsabilidades
* Como objetos são criados e utilizados
* Boas práticas no uso de classes

## 1. O que é uma Classe?

Uma **classe** é um modelo (ou molde) que define:

* **Estado** → quais dados um objeto possui
* **Comportamento** → quais ações ele pode executar

#### **A classe é um Molde?**

Quando pensamos em um **carro**, não pensamos em um automóvel específico,
mas sim no **conceito** de carro.

**O que ele tem?**  
Modelo, ano, quilometragem  

**O que ele faz?**  
Dá partida, acelera, freia  

Uma classe representa exatamente isso:  
ela define **o que um objeto é** e **o que ele pode fazer**, mas não é o objeto 
em si.

Em C#, uma classe é declarada com a palavra-chave `class`.

```csharp
class Car
{
    public string _modelo;
    public int _ano;

    public void Start()
    {
        Console.WriteLine("O carro está ligado.");
    }
}
```

### Componentes de uma Classe

Uma classe pode conter:

* **Campos** → São as variaveis internas da classe, onde armazenamos informações 
sobre o estado do objeto.

    ```csharp
    public string nome
    private string _modelo;
    private int _ano;
    ```

* **Propriedades** → controlam o acesso aos dados, elas que vão permitir acessar
e modificar os campos existentes na classe.

    ```csharp 
    public string nome {get; set;}
    ```
    Ou de forma mais explicita:

    ```csharp 
        public string nome 
        {
            get{return nome;}
            set{nome = value;}
        }
    ```

* **Construtores** → inicializam o objeto preparando ele para uso, definindo 
valores iniciais ppara seu atributos e alocando os recursos necessarios.

    ```csharp
    public Car(string modelo, int ano)
    {
        _modelo = modelo;
        _ano = ano;
    }
    ```

* **Métodos** → definem ações e comportamentos de uma classe.

    ```csharp 
    public void Ligar()
    {
        Console.Write("Vrummm");
    }
    ```

* **Modificadores de acesso** → definem visibilidade (`public`, `private`, etc.)
    
    * **public** → acesso global, Pode ser acessado por qualquer classe, em 
    qualquer projeto que referencie o assembly
    * **private** → acesso restrito à própria classe 
    * **protected** → acesso permitido à classe atual e às classes que herdam dela
    Muito usado em cenários de herança para permitir extensão de comportamento 
    sem expor tudo publicamente
    * **internal** → acesso restrito ao mesmo assembly Classes ou membros 
    internal não podem ser acessados por outros projetos, mesmo que referenciem
    o assembly

    > Assembly = o “pacote” final gerado quando você compila um projeto

## 2. Classe vs Objeto

* **Classe** → é o modelo, uma representação generalizada
* **Objeto** → é a instância criada a partir da classe

```csharp
Car car1 = new Car();
Car car2 = new Car();
```

Cada objeto:

* Possui seu próprio espaço na memória
* Mantém seu próprio estado
* Funciona de forma independente

```csharp
car1.Model = "Civic";
car2.Model = "Corolla";
```

Mesmo sendo da mesma classe, `car1` e `car2` são objetos diferentes.


## 3. Estrutura Básica de uma Classe

Em um primeiro momento, para fins de aprendizado, uma classe pode ser apresentada de forma mais simples, utilizando campos públicos para representar seus dados

```csharp
class Car
{
    public string modelo;
    public int ano;

    public void Start()
    {
        Console.WriteLine($"{modelo} está ligado.");
    }
}
```

Uma estrutura mais organizada utiliza **propriedades**, em aplicações reais, é 
importante que se utilize propriedades no lugar de campos públicos::

```csharp
class Car
{
    public string modelo { get; set; }
    public int ano { get; set; }

    public void Start()
    {
        Console.WriteLine($"{modelo} está ligado.");
    }
}
```

Essa abordagem melhora o **encapsulamento**, pois permite controlar o acesso aos dados.

### Por que usar propriedades?
As propriedades funcionam como um ponto controlado de acesso aos dados da classe.
Diferente de campos públicos, elas permitem que regras sejam aplicadas sem expor diretamente o estado interno do objeto.

Internamente, uma propriedade possui:

* get → responsável pela leitura do valor
* set → responsável pela atribuição do valor

Ou seja, o acesso aos dados passa por uma camada de controle        

## 4. Inicialização e Instanciação

Criar um objeto a partir de uma classe é chamado de **instanciação**.
Esse processo ocorre quando utilizamos a palavra-chave `new`:

```csharp
Car myCar = new Car();
```

### O que acontece durante a instanciação?

Ao instanciar um objeto:

**1.** **Memória é alocada no heap.**  
O runtime reserva espaço suficiente para armazenar todos os dados da classe.

**2.** **Valores padrão são atribuídos aos campos e propriedades.**  
Antes de qualquer código do construtor ser executado, o objeto já possui um estado inicial válido.

**3.** **O construtor da classe é executado.**  
É nesse ponto que o desenvolvedor pode sobrescrever os valores padrão e aplicar regras iniciais.

### O que são valores padrão?

Valores padrão são os valores iniciais automáticos que o C# atribui aos membros de uma classe quando um objeto é criado sem inicialização explícita.

**Eles garantem que:**

* nenhum campo contenha “lixo de memória”
* o objeto sempre comece em um estado previsível

### Valores padrão em C#

|  Tipo                           |    Valor padrão   |
|---------------------------------|-------------------|
| `int`, `long`, `short`          | `0`               |
| `float`, `double`, `decimal`    | `0` / `0.0`       |
| `bool`                          | `false`           |
| `char`                          | `'\0'` (nulo)     |
| `string`                        | `null`            |
| Tipos de referência (classes)   | `null`            |
| `DateTime`                      | `01/01/0001`      |

#### Exemplo prático

Considere a classe abaixo:

```csharp
class Car
{
    public string modelo;
    public int ano;
    public bool estaLigado;
}
```

Ao criar o objeto:

```csharp
Car car = new Car();
```

O estado inicial será:

`modelo` → `null`

`ano` → `0`

`estaLigado` → `false`

Mesmo sem atribuir valores manualmente, o objeto já está totalmente inicializado.

## 5. Construtores

O **construtor** garante que o objeto já nasça em um estado válido.

### Construtor Padrão

```csharp
class Player
{
    public int Health;

    public Player()
    {
        Health = 100;
    }
}
```

### Construtor com Parâmetros

```csharp
class Player
{
    public string Name { get; private set; }
    public int Health { get; private set; }

    public Player(string name)
    {
        Name = name;
        Health = 100;
    }
}
```

### Uso

```csharp
Player player = new Player("Arthur");
```

**Vantagem:** evita que o objeto seja criado incompleto ou inválido.

## 6. Exemplo Prático de Uso

Simulação simples de um sistema de pedidos:

```csharp
class Order
{
    public string Product { get; }
    public int Quantity { get; }

    public Order(string product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public decimal CalculateTotal(decimal price)
    {
        return price * Quantity;
    }
}
```

### Uso

```csharp
Order order = new Order("Teclado", 2);
decimal total = order.CalculateTotal(150);
```

A classe:

* Armazena informações do pedido
* Garante criação correta do objeto
* Executa cálculos relacionados ao seu próprio contexto

Isso demonstra boa organização orientada a objetos.

## 7. Boas Práticas no Uso de Classes

* Utilizar propriedades ao invés de campos públicos
* Garantir estado válido via construtor
* Aplicar encapsulamento
* Usar nomes claros e semânticos
* Manter responsabilidade única
* Evitar classes "faz-tudo"

## 8. Resumo Final

Uma classe em C#:

* É um modelo para criar objetos
* Define estado e comportamento
* Pode possuir construtores para garantir validade
* Deve seguir princípios de Orientação a Objetos
* Deve ter responsabilidade clara e bem definida

Inicializar corretamente uma classe significa criar **objetos consistentes, previsíveis e seguros** para uso dentro do sistema.

> Nota: Este conteúdo foi desenvolvido com suporte de ferramentas de IA como auxílio
> à escrita e organização, com revisão e validação técnica humana.

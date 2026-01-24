# Inicialização de Classes em C#

Este material tem como objetivo apresentar o conceito de inicialização de classes em C#, 
explicando como objetos são criados e preparados para uso dentro do paradigma de 
Programação Orientada a Objetos.

## O que é uma classe

Em C#, uma **classe** pode ser entendida como um molde ou modelo que define as 
características e os comportamentos de um objeto.

    class Car
    {
        public string Model;
        public int Year;

        public void Start()
        {
            Console.WriteLine("O carro está ligado.");
        }
    }
Uma classe pode conter:
- Campos e propriedades, que representam os dados
- Métodos, que representam os comportamentos

A classe por si só não executa ações; ela apenas descreve como os objetos devem ser.

## O que significa inicializar uma classe

Inicializar uma classe significa **criar um objeto a partir dessa classe**.  
Esse processo também é chamado de **instanciação**.

    Car myCar = new Car();

Durante a inicialização:
- Um espaço de memória é alocado
- Os campos recebem valores iniciais
- O construtor da classe é executado

Após esse processo, o objeto está pronto para ser utilizado no código.

## Instanciando objetos com `new`

Em C#, objetos são criados utilizando a palavra-chave `new`.

    Car car1 = new Car();
    Car car2 = new Car();

    car1.Model = "Civic";
    car2.Model = "Corolla";

    Console.WriteLine(car1.Model); // Civic
    Console.WriteLine(car2.Model); // Corolla

Cada vez que uma classe é instanciada:
- Um novo objeto independente é criado
- Cada objeto possui seu próprio estado

Mesmo que dois objetos sejam criados a partir da mesma classe, eles não compartilham
seus dados automaticamente.

## Construtores

O **construtor** é um método especial responsável por inicializar o objeto.

    class Player
    {
        public int Health;

        public Player()
        {
            Health = 100;
        }
    }
    Player player = new Player();
    Console.WriteLine(player.Health); // 100


Características do construtor:
- Possui o mesmo nome da classe
- Não possui tipo de retorno
- É executado automaticamente no momento da instanciação
---
    class Player
    {
        public string Name;
        public int Health;

        public Player(string name)
        {
            Name = name;
            Health = 100;
        }
    }

    Player player = new Player("Arthur");
    Console.WriteLine(player.Name);   // Arthur
    Console.WriteLine(player.Health); // 100


Uma classe pode ter:
- Um construtor padrão (sem parâmetros)
- Um ou mais construtores com parâmetros

Construtores são utilizados para garantir que o objeto seja criado em um estado válido.

## Inicialização de campos e propriedades
Os campos e propriedades de uma classe podem ser inicializados de diferentes formas:

- Valores padrão do C#  
  - `int` inicia com `0`
  - `bool` inicia com `false`
  - `string` inicia com `null`

- Inicialização direta no campo ou propriedade

- Inicialização através do construtor

A escolha da abordagem depende da regra de negócio e da necessidade de cada objeto.

    class Example
    {
        public int Number;
        public bool IsActive;
        public string Text;
    }
    Example example = new Example();

    Console.WriteLine(example.Number);   // 0
    Console.WriteLine(example.IsActive); // false
    Console.WriteLine(example.Text);     // null


## Relação com Orientação a Objetos

A inicialização de classes está diretamente ligada aos conceitos de orientação a objetos:

- **Encapsulamento**: o objeto controla seu próprio estado
- **Estado**: valores armazenados nos campos e propriedades
- **Comportamento**: métodos que utilizam esse estado

Inicializar corretamente uma classe garante que o objeto esteja consistente e seguro
para interagir com o restante do sistema.

## Boas práticas

- Sempre inicializar objetos antes de utilizá-los
- Utilizar construtores para definir valores obrigatórios
- Evitar deixar objetos em estados inválidos
- Manter a lógica de inicialização dentro da própria classe
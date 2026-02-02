/*
    O exercecio tem como objetivo mostrar um dos pilares da programação 
    orientada a objetos, a herança, grande responsavel pelo reaproveitamento de 
    codigo em linguagens deste paradigma.

    Conceitos desta questão: 
    - Herança (ou inheritance)
    - Modificadores de acesso
*/
/*
    Classe base para todos os personagens do jogo.
    Define comportamento comum como vida, dano e vulnerabilidade.
*/
abstract class Character
{
    // Vida inicial padrão de qualquer personagem
    public int life = 100;

    //Construtor protegido para impedir instanciação direta da classe base
    protected Character(string characterType) { }

    // Calcula o dano causado ao alvo de acordo com as regras da classe
    public abstract int DamagePoints(Character target);

    // Indica se o personagem está vulnerável a ataques
    // Por padrão, personagens não são vulneráveis
    public virtual bool Vulnerable() => false;

    // Retorna o tipo do personagem para exibição ou debug
    public override string ToString() => $"Character is a {this.GetType().Name}";
}
/*
    Guerreiro focado em combate físico.
    Causa mais dano contra inimigos vulneráveis.
*/
class Warrior : Character
{
    public Warrior() : base("TODO") { }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable())
        {
            target.life -= 10;
            return 10;
        }
        target.life -= 6;
        return 6;
    }
}
/*
    Mago que pode preparar um feitiço para causar dano elevado.
    Enquanto prepara o feitiço, fica vulnerável.
*/
class Wizard : Character
{
    public bool _spellInPreparation; // Indica se o feitiço está preparado

    public Wizard() : base("TODO") { }

    // O mago fica vulnerável quando não está preparando um feitiço
    public override bool Vulnerable() => _spellInPreparation ? false : true;

    public override int DamagePoints(Character target)
    {
        if (_spellInPreparation)
        {
            target.life -= 12;
            _spellInPreparation = false;
            return 12;
        }
        target.life -= 3;
        return 3;
    }

    // Prepara o feitiço para o próximo ataque
    public void PrepareSpell() => _spellInPreparation = true;
}
/*
    Ao falar de herança na Programação Orientada a Objetos, falamos também
    diretamente sobre os modificadores da linguagem, que controlam
    visibilidade, acesso e reutilização de código entre classes.

    Falando primeiro sobre os modificadores de acesso em C# temos:
    - public:
      O membro pode ser acessado por qualquer classe, em qualquer contexto.

    - private:
      O membro só pode ser acessado dentro da própria classe onde foi definido.

    - protected:
      O membro pode ser acessado pela própria classe e por classes derivadas.

    - internal:
      O membro pode ser acessado por qualquer classe dentro da mesma distribuição.

    Modificadores de herença: 

    Modificadores relacionados à herança:

    - virtual:
      Indica que um método ou propriedade pode ser sobrescrito
      em uma classe derivada.

    - override:
      Usado na classe filha para sobrescrever a implementação
      de um membro marcado como virtual na classe base.

    - abstract:
      Define um membro sem implementação.
      Obriga as classes derivadas a fornecerem sua própria implementação.

    - sealed:
      Impede que uma classe seja herdada ou que um método sobrescrito
      seja novamente sobrescrito por classes filhas.

    Outros modificadores importantes (comportamento e execução):

    - static:
      Define que o membro pertence à classe e não a uma instância.
      Pode ser acessado sem criar um objeto da classe.

    - readonly:
      Permite que o valor de um campo seja atribuído apenas
      na declaração ou dentro do construtor.
      Após isso, o valor não pode ser alterado.

    - async:
      Indica que um método é assíncrono e pode executar operações
      sem bloquear a thread principal, geralmente em conjunto com 'await'.

    Esses modificadores ajudam a controlar não apenas herança,
    mas também estado, concorrência e organização do código,
    tornando a aplicação mais segura e eficiente.
*/
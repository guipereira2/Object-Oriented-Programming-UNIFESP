// Implemente as classes a seguir utilizando os conceitos de Programação Orientada a Objetos:

// (a) Crie uma classe Pessoa com os atributos privados nome e idade. Implemente métodos de acesso (getters) e modificação (setters). No setter de idade, garanta que apenas valores positivos sejam aceitos.
//
// (b) Crie uma classe Aluno, que herda de Pessoa, adicionando o atributo nota. Implemente os métodos de acesso e modificação, garantindo que a nota esteja entre 0 e 10.
//
// (c) Utilize polimorfismo para sobrescrever um método exibir_dados(), de modo que:
//      • na classe Pessoa, exiba nome e idade;
//      • na classe Aluno, exiba nome, idade e nota.

namespace lista
{
    public class Pessoa
    {
        private string nome;
        private int idade;

        public int getter_idade()
        {
            return idade;
        }

        public string getter_nome()
        {
            return nome;
        }

        public void setter_idade(int idade)
        {
            if (idade > 0)
            {
                this.idade = idade;
            }
            else
            {
                throw new Exception("A idade precisa ser positiva (> 0).");
            }
        }

        public void setter_nome(string nome)
        {

            this.nome = nome;
        }

        public virtual void exibir_dados()
        {
            Console.WriteLine($"Nome: {this.getter_nome()}, Idade: {this.getter_idade()}");
        }
    }

    public class Aluno : Pessoa
    {
        private double nota;

        public double getter_nota()
        {
            return nota;
        }
        public void setter_nota(double nota)
        {
            if (nota >= 0 && nota <= 10)
            {
                this.nota = nota;
            }
            else
            {
                throw new Exception("A nota precisa estar entre 0 e 10");
            }
        }

        public override void exibir_dados()
        {
            Console.WriteLine($"Nome: {this.getter_nome()}, Idade: {this.getter_idade()}, Nota: {this.getter_nota()}");
        }

    }

    internal class Program
    {
        static void Main()
        {
            Aluno aluno = new Aluno();
            aluno.setter_nome("aluno");
            aluno.setter_idade(18);
            aluno.setter_nota(9.4);
            aluno.exibir_dados();
        }
    }
}

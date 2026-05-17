// Exercício 2. Utilize os conceitos de POO abordados em aula para resolver os seguintes itens:
//
// (a) Construa uma classe Numero_Natural com apenas um atributo protegido n que deve ser um valor inteiro não negativo. Garanta, por meio do método de configuração set_n, que apenas valores inteiros positivos serão atribuídos a n. O construtor desta classe deve receber um parâmetro n que pode ser tanto um valor inteiro positivo quanto um valor literal que represente um inteiro positivo. No segundo caso, converta o literal para inteiro antes de configurar n.
//
// (b) Construa uma classe Numero_Inteiro, herdeira de Numero_Natural. Usando polimorfismo, ajuste o método set_n para aceitar qualquer número inteiro (positivo, negativo ou zero).
//
// (c) Construa uma classe Numero_Racional definida por dois atributos privados, ambos objetos da classe Numero_Inteiro: numerador e denominador. Utilize encapsulamento para definir métodos de acesso e configuração. O atributo denominador não pode assumir valor nulo; implemente a validação no respectivo setter

// Naturais: inteiros, >= a 0

namespace lista
{
    // (a) Construa uma classe Numero_Natural com apenas um atributo protegido n que deve ser um valor inteiro não negativo. Garanta, por meio do método de configuração set_n, que apenas valores inteiros positivos serão atribuídos a n. O construtor desta classe deve receber um parâmetro n que pode ser tanto um valor inteiro positivo quanto um valor literal que represente um inteiro positivo. No segundo caso, converta o literal para inteiro antes de configurar n.

    public class Numero_Natural
    {
        protected int n;

        public virtual void set_n(int n)
        {
            if (n >= 0)
            {
                this.n = n;
            }
            else
            {
                throw new Exception("Natural >= 0");
            }
        }

        public Numero_Natural(int n)
        {
            if (n >= 0)
            {
                this.n = n;
            }
            else
            {
                throw new Exception("Natural >= 0");
            }
        }

        public Numero_Natural(string n)
        {
            int natural = Convert.ToInt32(n);
            if (natural >= 0)
            {
                this.n = natural;
            }
            else
            {
                throw new Exception("Natural >= 0");
            }
        }

        public Numero_Natural()
        {
            this.n = n;
        }

        public int get_n()
        {
            return n;
        }


    }

    // (b) Construa uma classe Numero_Inteiro, herdeira de Numero_Natural. Usando polimorfismo, ajuste o método set_n para aceitar qualquer número inteiro (positivo, negativo ou zero).

    public class Numero_Inteiro : Numero_Natural
    {
        public override void set_n(int n)
        {
            this.n = n;
        }

    }

    // (c) Construa uma classe Numero_Racional definida por dois atributos privados, ambos objetos da classe Numero_Inteiro: numerador e denominador. Utilize encapsulamento para definir métodos de acesso e configuração. O atributo denominador não pode assumir valor nulo; implemente a validação no respectivo setter

    public class Numero_Racional
    {
        private Numero_Inteiro numerador;
        private Numero_Inteiro denominador;

        public Numero_Inteiro get_numerador()
        {
            return numerador;
        }

        public void set_numerador(Numero_Inteiro numerador)
        {
            this.numerador = numerador;
        }

        public Numero_Inteiro get_denominador()
        {
            return denominador;
        }

        public void set_denominador(Numero_Inteiro denominador)
        {
            if (denominador.get_n() != 0)
            {
                this.denominador = denominador;
            }
            else
            {
                throw new Exception("denominador nulo!");
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            Numero_Inteiro numerador = new Numero_Inteiro();
            Numero_Inteiro denominador = new Numero_Inteiro();
            Console.WriteLine("Objetos Numero_Inteiro criados");

            numerador.set_n(3);
            denominador.set_n(4);
            Console.WriteLine($"Numerador: {numerador.get_n()}, Denominador: {denominador.get_n()}");

            Numero_Racional racional = new Numero_Racional();
            Console.WriteLine("Objeto Numero_Racional criado");

            racional.set_denominador(denominador);
            Console.WriteLine("Denominador atribuído");

            racional.set_numerador(numerador);
            Console.WriteLine("Numerador atribuído");

            Console.WriteLine($"Racional criado: {racional.get_numerador().get_n()}/{racional.get_denominador().get_n()}");
        }
    }
}

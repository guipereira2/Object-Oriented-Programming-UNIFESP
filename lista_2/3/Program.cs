// Exercício 3. Modifique a classe Numero_Racional definida no exercício anterior acrescentando:
//
// (a) Um método show que apresente na tela os atributos numerador e denominador no formato numerador / denominador.
//
// (b) Sobrecarga do operador lógico de igualdade == para decidir se dois objetos de Numero_Racional são iguais.
//
// (c) Sobrecarga do operador de soma + para permitir somar dois objetos Numero_Racional. Especificamente, se r1 e r2 têm numeradores a1, a2 e denominadores b1, b2, então r3 = r1 + r2 deve ter numerador a1b2 + a2b1 e denominador b1b2.


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

        // (a) Um método show que apresente na tela os atributos numerador e denominador no formato numerador / denominador.

        public void show()
        {
            Console.WriteLine($"{this.get_numerador().get_n()} / {this.get_denominador().get_n()}");
        }

        // (b) Sobrecarga do operador lógico de igualdade == para decidir se dois objetos de Numero_Racional são iguais.

        public static bool operator ==(Numero_Racional a, Numero_Racional b)
        {
            if ((1.0 * a.get_numerador().get_n() / 1.0 * a.get_denominador().get_n()) == (1.0 * b.get_numerador().get_n() / 1.0 * b.get_denominador().get_n()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Numero_Racional a, Numero_Racional b)
        {
            if ((1.0 * a.get_numerador().get_n() / 1.0 * a.get_denominador().get_n()) != (1.0 * b.get_numerador().get_n() / 1.0 * b.get_denominador().get_n()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // (c) Sobrecarga do operador de soma + para permitir somar dois objetos Numero_Racional. Especificamente, se r1 e r2 têm numeradores a1, a2 e denominadores b1, b2, então r3 = r1 + r2 deve ter numerador a1b2 + a2b1 e denominador b1b2.

        public static Numero_Racional operator +(Numero_Racional a, Numero_Racional b)
        {
            int num_a = a.get_numerador().get_n();
            int num_b = b.get_numerador().get_n();
            int den_a = a.get_denominador().get_n();
            int den_b = b.get_denominador().get_n();

            int num_c = (num_a * den_b) + (num_b * den_a);
            int den_c = den_a * den_b;

            Numero_Inteiro numerador_c = new Numero_Inteiro();
            Numero_Inteiro denominador_c = new Numero_Inteiro();

            numerador_c.set_n(num_c);
            denominador_c.set_n(den_c);

            Numero_Racional resultado = new Numero_Racional();
            resultado.set_numerador(numerador_c);
            resultado.set_denominador(denominador_c);

            return resultado;
        }
    }

    internal class Program
    {
        static void Main()
        {
            //-------------------------------------------------
            Numero_Inteiro numerador = new Numero_Inteiro();
            Numero_Inteiro denominador = new Numero_Inteiro();

            numerador.set_n(1);
            denominador.set_n(2);

            Numero_Racional racional = new Numero_Racional();

            racional.set_denominador(denominador);
            racional.set_numerador(numerador);

            racional.show();

            //-----------------------------------------------
            Numero_Inteiro numerador2 = new Numero_Inteiro();
            Numero_Inteiro denominador2 = new Numero_Inteiro();

            numerador2.set_n(3);
            denominador2.set_n(4);

            Numero_Racional racional2 = new Numero_Racional();

            racional2.set_denominador(denominador2);
            racional2.set_numerador(numerador2);

            racional2.show();

            //-----------------------------------------------
            Console.WriteLine(racional == racional2);

            //-----------------------------------------------

            Numero_Racional racional3 = new Numero_Racional();
            racional3 = racional + racional2;
            racional3.show();

        }
    }
}

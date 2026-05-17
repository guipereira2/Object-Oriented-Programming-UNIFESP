// Exercício 4. Crie uma classe Carta com três atributos privados: valor, naipe e peso. Utilize encapsulamento para acessar e alterar os valores, observando:
//
//  • valor ∈ [A,2,3,4,5,6,7,8,9,10,J,Q,K];
//  • naipe ∈ [Paus, Copas, Espadas, Ouros];
//  • peso é um número real positivo.
//
// Sobrecaregue os operadores ==, > e < para comparar duas Cartas. Uma carta é maior que outra se o seu peso for maior.

namespace Lista
{

    public class Carta
    {
        private string valor;
        private string naipe;
        private double peso;

        public void set_valor(string v)
        {
            if (v == "A" || v == "2" || v == "3" || v == "4" || v == "5" || v == "6" || v == "7" || v == "8" || v == "9" || v == "10" || v == "J" || v == "Q" || v == "K")
            {
                this.valor = valor;
            }
            else
            {
                throw new Exception("Valor invalido");
            }
        }

        public void set_valor(int valor)
        {
            if (valor >= 2 && valor <= 10)
            {
                string valor_string = Convert.ToString(valor);
                this.valor = valor_string;
            }
            else
            {
                throw new Exception("Valor invalido");
            }
        }

        public string get_valor()
        {
            return this.valor;
        }

        public void set_naipe(string naipe)
        {
            if (naipe == "Paus" || naipe == "Copas" || naipe == "Espadas" || naipe == "Ouros")
            {
                this.naipe = naipe;
            }
            else
            {
                throw new Exception("Naipe invalido");
            }
        }

        public string get_naipe()
        {
            return this.naipe;
        }

        public void set_peso(double peso)
        {
            if (peso > 0)
            {
                this.peso = peso;
            }
            else
            {
                throw new Exception("Peso invalido");
            }
        }

        public double get_peso()
        {
            return this.peso;
        }

        // Sobrecaregue os operadores ==, > e < para comparar duas Cartas. Uma carta é maior que outra se o seu peso for maior.

        public static bool operator >(Carta a, Carta b)
        {
            if (a.peso > b.peso)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Carta a, Carta b)
        {
            if (a.peso < b.peso)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Carta a, Carta b)
        {
            if (a.peso == b.peso)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Carta a, Carta b)
        {
            if (a.peso != b.peso)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            Carta a = new Carta();
            Carta b = new Carta();

            a.set_peso(3);
            b.set_peso(4);

            Console.WriteLine(a < b);
        }
    }
}

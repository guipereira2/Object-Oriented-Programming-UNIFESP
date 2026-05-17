// Exercício 5.
//
// Crie uma classe Baralho com os seguintes atributos:
//      • valores_validos: lista de valores possíveis de uma carta;
//      • naipes_validos: lista de naipes possíveis;
//      • cartas: lista de objetos Carta do baralho.
//
// A classe deve seguir as convenções de encapsulamento e incluir os métodos:
//      • constroi_baralho: confecciona todas as cartas possíveis a partir de valores_validos e naipes_validos;
//      • embaralha: embaralha (aleatoriza) os índices de cartas;
//      • mostra_cartas: mostra todas as cartas em cartas;
//      • retira_carta_aleatoria: retira e retorna uma carta aleatória de cartas

namespace lista
{
    public class Baralho
    {
        private List<string> valores_validos = new List<string> { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        private List<string> naipes_validos = new List<string> { "Paus", "Copas", "Espadas", "Ouros" };
        private List<Carta> cartas = new List<Carta>();

        public void constroi_baralho()
        {
            foreach (string valor in valores_validos)
            {
                foreach (string naipe in naipes_validos)
                {
                    Carta c = new Carta();
                    c.set_naipe(naipe);
                    c.set_valor(valor);
                    cartas.Add(c);
                }
            }
        }

        public void embaralha()
        {
            Random random = new Random();
            for (int i = 0; i < cartas.Count; i++)
            {
                int indice_aleatorio = random.Next(0, cartas.Count);

                Carta temp = cartas[i];
                cartas[i] = cartas[indice_aleatorio];
                cartas[indice_aleatorio] = temp;
            }
        }

        public void mostra_cartas()
        {
            for (int i = 0; i < cartas.Count; i++)
            {
                Console.WriteLine($"{cartas[i].get_valor()},{cartas[i].get_naipe()}");
            }
        }

        public void retira_carta_aleatoria()
        {
            Random random = new Random();
            int indice_aleatorio = random.Next(0, cartas.Count);
            Console.WriteLine($"{cartas[indice_aleatorio].get_valor()}, {cartas[indice_aleatorio].get_naipe()}");
        }

    }

    public class Carta
    {
        private string valor;
        private string naipe;

        public void set_valor(string v)
        {
            if (v == "A" || v == "2" || v == "3" || v == "4" || v == "5" || v == "6" || v == "7" || v == "8" || v == "9" || v == "10" || v == "J" || v == "Q" || v == "K")
            {
                this.valor = v;
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
    }

    internal class Program
    {
        static void Main()
        {
            Baralho baralho = new Baralho();
            baralho.constroi_baralho();
            baralho.mostra_cartas();
            baralho.embaralha();
            Console.WriteLine("--------------");
            baralho.mostra_cartas();
            Console.WriteLine("--------------");
            baralho.retira_carta_aleatoria();
        }
    }
}

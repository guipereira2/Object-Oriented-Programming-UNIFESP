// Exercício 7. Crie uma classe Baralho_de_Truco, herdeira de Baralho, representando um baralho italiano com os seguintes pesos:
//
//      • Atributo vira: uma Carta virada na mesa.
//      • Método define_vira: escolhe aleatoriamente uma carta do baralho e a define como vira.
//      • Método atualiza_pesos: após define_vira, atualiza os pesos das manilhas (vedetes). Se a vira for a carta de peso p, as manilhas são as cartas de peso p + 1, exceto quando a vira for um 3, caso em que as manilhas são as cartas de valor 4. Ex.: se virar um Ás, as manilhas são as cartas de valor 2 (2 de ouros, 2 de espadas, 2 de copas, 2 de paus), que passam a ter os pesos das manilhas correspondentes.
//
// Por fim, defina um objeto desta classe e apresente as cartas e seus pesos antes e depois da execução de define_vira.

namespace lista
{
    public class Baralho
    {
        private List<string> valores_validos = new List<string> { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        private List<string> naipes_validos = new List<string> { "Paus", "Copas", "Espadas", "Ouros" };
        private List<Carta> cartas = new List<Carta>();

        public void set_valores_validos(List<string> valores)
        {
            valores_validos = valores;
        }

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
                Console.WriteLine($"{cartas[i].get_valor()},{cartas[i].get_naipe()}, {cartas[i].get_peso()}");
            }
        }

        public void retira_carta_aleatoria()
        {
            Random random = new Random();
            int indice_aleatorio = random.Next(0, cartas.Count);
            Console.WriteLine($"{cartas[indice_aleatorio].get_valor()}, {cartas[indice_aleatorio].get_naipe()}");
        }

        public List<Carta> get_cartas()
        {
            return cartas;
        }
    }

    public class Baralho_de_truco : Baralho
    {
        private Carta vira;

        public void atribui_pesos()
        {
            foreach (Carta c in get_cartas())
            {
                string valor = c.get_valor();
                if (valor == "4") c.set_peso(0);
                else if (valor == "5") c.set_peso(1);
                else if (valor == "6") c.set_peso(2);
                else if (valor == "7") c.set_peso(3);
                else if (valor == "Q") c.set_peso(4);
                else if (valor == "J") c.set_peso(5);
                else if (valor == "K") c.set_peso(6);
                else if (valor == "A") c.set_peso(7);
                else if (valor == "2") c.set_peso(8);
                else if (valor == "3") c.set_peso(9);
            }
        }

        public Carta define_vira()
        {

            Random random = new Random();
            int indice_aletatorio = random.Next(0, get_cartas().Count);
            vira = get_cartas()[indice_aletatorio];
            return vira;
        }

        public void atualiza_pesos()
        {
            vira = define_vira();
            double peso = vira.get_peso();
            foreach (Carta c in get_cartas())
            {
                if (c.get_peso() == peso + 1)
                {
                    if (c.get_naipe() == "Ouros")
                    {
                        c.set_peso(10);
                    }
                    if (c.get_naipe() == "Espadas")
                    {
                        c.set_peso(11);
                    }
                    if (c.get_naipe() == "Copas")
                    {
                        c.set_peso(12);
                    }
                    if (c.get_naipe() == "Paus")
                    {
                        c.set_peso(13);
                    }
                }
            }
        }


    }
    public class Carta
    {
        private string valor;
        private string naipe;
        private double peso;

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

        public void set_peso(double peso)
        {
            if (peso >= 0)
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
            Baralho_de_truco truco = new Baralho_de_truco();
            truco.set_valores_validos(new List<string> { "A", "2", "3", "4", "5", "6", "7", "J", "Q", "K" });
            truco.constroi_baralho();
            truco.atribui_pesos();
            truco.mostra_cartas();
            Console.WriteLine("---------------------------------");
            truco.atualiza_pesos();
            truco.mostra_cartas();
        }
    }
}

// Exercício 3. Considere a classe Q definida a seguir:

namespace lista
{
    internal class Q
    {
        private int Numerador;
        private int Denominador;

        public Q(int numerador, int denominador)
        {
            SetNumerador(numerador);
            SetDenominador(denominador);
        }

        public void SetNumerador(int n)
        {
            Numerador = n;
        }

        public int GetNumerador()
        {
            return Numerador;
        }

        public void SetDenominador(int n)
        {
            if (n != 0)
            {
                Denominador = n;
            }
            else
            {
                throw new Exception("Nao eh possivel definir denominador nulo.");
            }
        }

        public int GetDenominador()
        {
            return Denominador;
        }


        // Função Main:
        static void Main(string[] args)
        {
            Q q1 = new Q(1, 2),
              q2 = new Q(1, 1),
              q3,
              q4 = new Q(1, 0);

            Console.WriteLine(q1);

            Console.WriteLine(q1 + q2);

            Console.ReadKey();
        }
    }
}

// (a) O primeiro Console.WriteLine apresentará o valor 0.5 na tela.

// Não, irá apresentar o nome do tipo do objeto.

// (b) O segundo Console.WriteLine apresentará o valor 1.5 na tela.

// Não, a classe Q nao define sobrecarga de operadores então não seria possível realizar essa operação.

// (c) Uma forma de apresentar o valor de q1 de maneira fracionária na tela seria:
//     Console.WriteLine($"q1.Numerador / q1.Denominador");

// Não, precisa usar o getter neesse caso pois os atributos são private

// (d) q3 é um objeto do tipo Q.

// q3 é uma variável do tipo Q mas não um objeto pois não foi instanciado.

// (e) O código do método Main não será executado corretamente por duas razões.
//     Primeiro, o segundo comando de saída não conseguirá processar q1 + q2,
//     pois a classe Q não define uma sobrecarga para o operador +.
//     Segundo, a criação de q4 resultará em uma exceção, pois o denominador é 0.

// Correto

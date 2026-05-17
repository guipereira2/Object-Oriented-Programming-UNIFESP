// Exercício 4. Considere o código a seguir, que utiliza a classe Q definida
// no exercício anterior, agora aplicada em um vetor de objetos:

internal class Program
{
    static void Main(string[] args)
    {
        Q[] fracoes = new Q[3];

        fracoes[0].SetNumerador(1);
        fracoes[0].SetDenominador(2);

        fracoes[1] = new Q(3, 4);

        fracoes[2].SetNumerador(5);
        fracoes[2].SetDenominador(6);

        for (int i = 0; i < fracoes.Length; i++)
        {
            Console.WriteLine($"Fracao {i + 1}: {fracoes[i].GetNumerador()}/{fracoes[i].GetDenominador()}");
        }

        Console.ReadKey();
    }
}

// (a) O código acima "compila" e executa corretamente? Justifique sua resposta.

// Não, apenas o fracoes[1] é instanciado, o resto das posições estão nulas.

// (b) Explique o que de fato é criado em memória quando o comando
//     Q[] fracoes = new Q[3]; é executado.

//  Um vetor de 3 posições nulas que assume valores do tipo Q.

// (c) Por que ocorre um erro ao executar as linhas
//     fracoes[0].SetNumerador(1); e fracoes[2].SetDenominador(6);?

// Pois esses valores de fracoes não foram instanciados.

// (d) Reescreva o trecho de código necessário para que o vetor de objetos
//     fracoes seja corretamente instanciado e o programa execute sem erros.

Q[] fracoes = new Q[3];

fracoes[0] = new Q(1, 2);
fracoes[1] = new Q(3, 4);
fracoes[2] = new Q(5, 6);

// (e) Explique a diferença conceitual entre definir o tamanho de um vetor
//     e instanciar os objetos que o mesmo armazena.

// Definir o tamanho de um vetor significa alocar espaço na memória para armazenar 3 referências do tipo Q, todas iniciadas como null, ja instancia significa criar um objeto Q na memória e atribui-lo a uma posição do vetor.

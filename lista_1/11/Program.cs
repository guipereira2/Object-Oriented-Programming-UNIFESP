// Implemente busca linear em um vetor int[] que retorna -1 se não encontrar.

int BuscaLinear(int[] vetor, int alvo)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        if (vetor[i] == alvo)
        {
            return 1;
        }
    }
    return -1;
}

Console.WriteLine("N");
int N = Convert.ToInt32(Console.ReadLine());
int[] vet = new int[N];
for (int j = 0; j < N; j++)
{
    vet[j] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Alvo: ");
int Alvo = Convert.ToInt32(Console.ReadLine());
int busca = BuscaLinear(vet, Alvo);
Console.WriteLine(busca);

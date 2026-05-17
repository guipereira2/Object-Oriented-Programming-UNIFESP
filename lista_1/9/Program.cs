// Gere um int[] vec de tamanho N com valores tais que vec[i] = i^2. Imprima:
// (a) todos os elementos com foreach;
// (b) apenas os pares;
// (c) a soma dos ímpares.

Console.WriteLine("N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] vec = new int[N];
int soma = 0;
for (int i = 0; i < N; i++)
{
    vec[i] = i * i;
    Console.WriteLine(vec[i]);
}
Console.WriteLine("--------------------");
for (int i = 0; i < N; i++)
{
    if (vec[i] % 2 == 0)
    {
        Console.WriteLine(vec[i]);
    }
}
Console.WriteLine("--------------------");
for (int i = 0; i < N; i++)
{
    if (vec[i] % 2 != 0)
    {
        soma = soma + vec[i];
    }
}
Console.WriteLine(soma);

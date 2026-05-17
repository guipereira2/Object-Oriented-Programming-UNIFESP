// Leia M nomes (string[]). Depois leia um nome alvo e conte, usando foreach, quantas ocorrências existem. Mostre também os índices onde aparece.

Console.WriteLine("N:");
int ocorrencias = 0;
int tamanho = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Alvo: ");
string Alvo = Console.ReadLine().Trim();
string[] nomes = new string[tamanho];

for (int i = 0; i < tamanho; i++)
{
    Console.WriteLine($"Nome: {i}");
    nomes[i] = Console.ReadLine();
}

for (int i = 0; i < tamanho; i++)
{
    if (nomes[i] == Alvo)
    {
        ocorrencias += 1;
        Console.WriteLine($"indice: {i}");
    }
}

Console.WriteLine($"Ocorrencias: {ocorrencias}");

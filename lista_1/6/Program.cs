Directory.CreateDirectory("dados");

int tamanho = Directory.GetFiles("../5/dados").Length;
int[] arr = new int[tamanho];

for (int i = 0; i < tamanho; i++)
{
    arr[i] = Convert.ToInt32(File.ReadAllText($"../5/dados/arquivo{i}.txt"));
    Console.WriteLine(arr[i]);
}

int soma = 0;
foreach (int i in arr)
{
    soma = soma + i;
}

Console.WriteLine($"Soma: {soma}");

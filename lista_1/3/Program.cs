using System.Runtime.InteropServices;

Console.WriteLine("Digite números separados por espaços");

string entrada = Console.ReadLine();
string[] temp = entrada.Split(' ');
int tamanho = temp.Length;
int[] numeros = new int[tamanho];
int soma = 0;

for (int i = 0; i < tamanho; i++)
{
    numeros[i] = Convert.ToInt32(temp[i]);
}

for (int i = 0; i < tamanho; i++)
{
    soma = soma + numeros[i];
}

for (int i = 0; i < tamanho; i++)
{
    for (int j = i + 1; j < tamanho; j++)
    {
        if (numeros[i] > numeros[j])
        {
            int x = numeros[j];
            numeros[j] = numeros[i];
            numeros[i] = x;
        }
    }
}


double media = soma / (tamanho * 1.0);
media = Math.Round(media, 2);

Console.WriteLine($"Maior: {numeros[tamanho - 1]}, Menor: {numeros[0]}, média: {media}");


// for (int i = 0; i < tamanho; i++)
// {
// Console.Write(numeros[i]);
// }

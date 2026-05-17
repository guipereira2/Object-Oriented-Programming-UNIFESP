// Normalize uma matriz de reais n × m para a faixa [0, 1] usando min–max por coluna (fmin-max(x) = 15 (x−xmin,i / xmax,i)−xmin,i  − 1, sendo xmin,i e xmax,i os valores mínimo e máximo, respectivamente, presentes na i-ésima coluna da matriz). Salve as matrizes original e normalizada em arquivos .CSV.

Console.WriteLine("n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("m");
int m = Convert.ToInt32(Console.ReadLine());
double[,] matriz = new double[n, m];
string conteudo = "";
string conteudo_normalizado = "";
double maior = 0;
double menor = double.MaxValue;

double[,] minmax(double[,] matriz)
{
    for (int i = 0; i < m; i++)
    {
        maior = 0;
        menor = double.MaxValue;
        for (int j = 0; j < n; j++)
        {
            if (matriz[j, i] > maior)
            {
                maior = matriz[j, i];
            }
            if (matriz[j, i] < menor)
            {
                menor = matriz[j, i];
            }
        }
        for (int j = 0; j < n; j++)
        {
            matriz[j, i] = (matriz[j, i] - menor) / (maior - menor);
        }
    }
    return matriz;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.WriteLine($"matriz{i}, {j}");
        matriz[i, j] = Convert.ToDouble(Console.ReadLine());
        conteudo += matriz[i, j] + " ";
    }
    conteudo += "\n";
}

double[,] matriz_normalizada = minmax(matriz);

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.WriteLine($"matriz{i}, {j}");
        conteudo_normalizado += matriz_normalizada[i, j] + " ";
    }
    conteudo_normalizado += "\n";
}

Console.WriteLine("--------------");
Console.WriteLine(conteudo);
Console.WriteLine("--------------");
Console.WriteLine(conteudo_normalizado);

Directory.CreateDirectory("matriz");
File.WriteAllText("./matriz/matriz.csv", conteudo);
File.WriteAllText("./matriz/matriz_normalizada.csv", conteudo_normalizado);

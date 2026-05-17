// Salve duas matrizes quadradas lidas pelo usuário e cujo número de linhas seja dado pelo usuário em A.txt e B.txt. Depois, leia, some, mostre o resultado e salve em C.txt

Directory.CreateDirectory("matriz");

int[,] matriz_A = new int[4, 3];
int[,] matriz_B = new int[3, 3];
int[,] matriz_soma = new int[3, 3];

string conteudo_A = "";
string conteudo_B = "";
string conteudo_C = "";


for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine($"matriz A: {i} ,{j}");
        matriz_A[i, j] = Convert.ToInt32(Console.ReadLine());
        conteudo_A += matriz_A[i, j] + " ";
    }
    conteudo_A += "\n";
}
File.WriteAllText("./matriz/matrizA.txt", conteudo_A);

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine($"matriz B: {i} ,{j}");
        matriz_B[i, j] = Convert.ToInt32(Console.ReadLine());
        conteudo_B += matriz_B[i, j] + " ";
    }
    conteudo_B += "\n";
}
File.WriteAllText("./matriz/MatrizB.txt", conteudo_B);

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matriz_soma[i, j] = matriz_A[i, j] + matriz_B[i, j];
        conteudo_C += matriz_soma[i, j] + " ";
    }
    conteudo_C += "\n";
}
File.WriteAllText("./matriz/MatrizSOMA.txt", conteudo_C);

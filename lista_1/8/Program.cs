// Implemente uma “lixeira” simples: mova todos os arquivos cujo valor ≤ 2 para lixeira e delete todos os com valor < 1. Mostre um relatório final.
Directory.CreateDirectory("lixeira");

int tamanho = Directory.GetFiles("../5/dados").Length;

for (int i = 0; i < tamanho; i++)
{
    if (Convert.ToInt32(File.ReadAllText($"../5/dados/arquivo{i}.txt")) <= 1)
    {
        File.Copy($"../5/dados/arquivo{i}.txt", $"lixeira/arquivo{i}.txt", true);
        Console.WriteLine($"Arquivo ../5/dados/arquivo{i}.txt sendo enviado para a lixeira");
    }
    else if (Convert.ToInt32(File.ReadAllText($"../5/dados/arquivo{i}.txt")) > 1)
    {
        File.Delete($"../5/dados/arquivo{i}.txt");
        Console.WriteLine($"Arquivo ../5/dados/arquivo{i}.txt sendo deletado");
    }
}

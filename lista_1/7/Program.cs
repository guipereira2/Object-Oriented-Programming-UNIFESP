//Copie todo o conteúdo de dados/ para backup/ (mantendo os nomes). Se o arquivo já existir em backup/, sobrescreva.

Directory.CreateDirectory("backup");
int tamanho = Directory.GetFiles("../5/dados").Length;
Console.WriteLine(tamanho);

for (int i = 0; i < tamanho; i++)
{
    File.Copy($"../5/dados/arquivo{i}.txt", $"backup/arquivo_backup{i}.txt", true);
    Console.WriteLine($"Copiando arquivo: {Path.GetFileName($"../5/dados/arquivo{i}")}");
}

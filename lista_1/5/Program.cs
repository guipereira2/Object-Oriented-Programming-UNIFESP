Console.WriteLine("N: ");
int N = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(Directory.GetCurrentDirectory());
Directory.CreateDirectory("dados");

for (int i = 0; i < N; i++)
{
    File.WriteAllText($"dados/arquivo{i}.txt", Convert.ToString(i));
    Console.WriteLine(Path.GetFileName($"dados/arquivo{i}.txt"));
}

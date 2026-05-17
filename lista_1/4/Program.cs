static double CtoF(double c)
{
    return 9 / 5 * c + 32 * 1.0;
}

static double IMC(double peso, double altura)
{
    return 1.0 * peso / (altura * altura);
}

bool menu = true;

while (menu == true)
{
    Console.WriteLine("1-Calcular IMC, 2-Converter Celsius→Fahrenheit, 0-Sair");
    int escolha = Convert.ToInt32(Console.ReadLine());
    if (escolha == 1)
    {
        Console.WriteLine("Altura(metros): ");
        double altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Peso(kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());
        double imc = IMC(peso, altura);
        imc = Math.Round(imc, 2);
        Console.WriteLine($"IMC: {imc}");
        menu = false;
    }
    if (escolha == 2)
    {
        Console.WriteLine("Celsius: ");
        double C = Convert.ToDouble(Console.ReadLine());
        double F = CtoF(C);
        F = Math.Round(F, 2);
        Console.WriteLine($"F: {F}");
        menu = false;
    }
    if (escolha == 0)
    {
        menu = false;
    }
}

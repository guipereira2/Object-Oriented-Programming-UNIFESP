// Considere a classe B, herdeira da classe A definida no Exercício 1 anterior e corrigida para não apresentar mais erros, definida na sequência:
//
internal class A
{
    private int x;
    protected int y;
    public int z;

    public A(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public A(int x, int y, int z)
    {
        this.x = x + 1;
        this.y = y + 2;
        this.z = z + 3;
    }
}

internal class B : A
{
    private int w;

    public B(int w)
    {
        this.w = w;

        MostraValores();
    }

    public void MostraValores()
    {
        Console.WriteLine($"x = {this.x}, y = {this.y}, z = {this.z}, w = {this.w}");
    }
}

// Sabe-se que existem dois problemas relacionados à orientação a objetos em C# com a definição de B. Destaque-os e comente como corrigi-los.

// O primeiro problema é a tentativa de acesso ao x, usando o this, o corrto seria definir um método get para ele e então chamar esse método, o segundo é a criação de um construtor em B sem chamar o construtor base de A. É preciso usar public B(int w): base(x, y, z)

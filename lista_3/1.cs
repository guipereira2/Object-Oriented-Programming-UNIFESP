// Exercício 1. Considere o trecho de código abaixo, escrito em C#
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

// (a)Explique qual é o papel do identificador this neste código e por que ele é necessário no contexto apresentado.

// O papel do identificador this nesse codigo é evitar a ambiguidade entre a assinatura da função que tem o mesmo nome do atributo, dessa forma com o this é possível atribuir o valor ao atributo sem ambiguidade. O this referencia a instância atual do objeto, permitindo diferenciar this.x (atributo da classe) de x (parâmetro do construtor).

// (b) O interpretador do C# será capaz de definir a classe A sem exceções ou erros? Caso negativo, diga qual conceito de orientação a objetos não foi respeitado e sugira uma maneira de corrigir o problema do código.

// Não será possível, a sobrecarga de construtores tem a mesma assinatura para resolver esse problema, temos que trocar os tipos de algum dos construtores i.e public A(double x, double y, double z).

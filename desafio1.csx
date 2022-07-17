public int[] ArrayConteudo(int[] conteudo)
{
    int[] numeros = new int[conteudo.Length];

    for (int i = 0; i < conteudo.Length; i++)
    {
        int joao = conteudo[i];
        numeros[i] = joao;
    }
    return numeros;
}

public void PrintArray(int[] numeros)
{
    foreach (int item in numeros)
    {
        Console.WriteLine(item);
    }
}

int[] x = ArrayConteudo(new int [] {8, 2, 10, 5});
PrintArray (x);
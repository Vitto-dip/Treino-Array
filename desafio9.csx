public int MenorNumero (int[] conteudo)
{
    int valor = 0;
    foreach(int item in conteudo)
    {
        if(item > valor)
        {
            valor = item;
        }
    }
    foreach(int item in conteudo)
    {
        if(item < valor)
        {
            valor = item;
        }
    }

    return valor;
}

int x = MenorNumero (new int[] {8, 2, 10, 5});
Console.WriteLine(x);
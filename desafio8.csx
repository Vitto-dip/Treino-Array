public int MaiorNumero (int[] conteudo)
{
    int maior = 0;
    foreach(int item in conteudo)
    {
        if(item > maior)
        {
            maior = item;
        }
    }
    return maior;
}



int x = MaiorNumero (new int[] {8, 2, 10, 5});
Console.WriteLine(x);
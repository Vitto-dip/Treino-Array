public int [] SequenciaLimiteDec (int limite)
{
    int[] array = new int[limite];

    for(int i = limite - 1; i >= 0; i--)
    {
        array[i] = limite - i;
    } 
    return array;
}

public void PrintArray(int[] numeros)
{
    foreach(int item in numeros)
    {
        Console.WriteLine(item);
    }
}

int [] x = SequenciaLimiteDec(5);
PrintArray(x);
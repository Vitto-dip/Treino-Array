public int [] Sequenciainvertida (int limite)
{
    int[] array = new int [limite];

    for(int i = limite - 1; i >= 0; i--)
    {
        array[i] = limite - i - 1;
    }
    return array;
}

public void PrintArray (int [] numeros)
{
    foreach(int item in numeros)
    {
        Console.WriteLine(item);
    }
}

int[] x = Sequenciainvertida(5);
PrintArray(x);
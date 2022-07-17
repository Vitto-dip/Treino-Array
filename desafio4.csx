public int[] SequenciaLimite(int limite)
{
    int[] array = new int [limite];
    for(int i = 0; i < limite; i++)
    {
        array[i] = i + 1;
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

int[] x = SequenciaLimite(5);
PrintArray(x);
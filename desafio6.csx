public int[] SequenINIeFim (int inicio, int fim)
{
    int[] array = new int[(fim - inicio) + 1];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = inicio++;
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

int[] x = SequenINIeFim(3, 8);
PrintArray(x);


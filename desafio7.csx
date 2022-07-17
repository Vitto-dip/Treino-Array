public int[] Sequencia7 (int inicio, int fim)
{
    int[] array = new int[(fim - inicio) + 1];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = fim--;
    }
    return array;
}

public void PrintArray(int[] array)
{
    foreach(int item in array)
    {
        Console.WriteLine(item);
    }
}

int[] x = Sequencia7 (3, 8);
PrintArray(x);
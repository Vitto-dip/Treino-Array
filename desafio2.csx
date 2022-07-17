public int[] Sequencia(int limite)
{
    int[] array = new int[limite];

    for(int i = 0; i < limite; i++)
    {
        array[i] = i; 
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

int[] x = Sequencia(5);
PrintArray(x);
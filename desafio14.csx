public int[] TabuadaArray(int valor){
    int[] array = new int[];
    for(int i = 0; i <= 10; i++){
        array[i] = i * valor;
    }
    return array;
}

public void PrintArray(int[] array){
    foreach (int item in array){
        Console.WriteLine(item);
    }
}

int[] x = TabuadaArray(4);
PrintArray(x);
public int[] Dobro(int[] array){
    for(int i = 0; i < array.Length; i++){
        array[i] = array[i] * 2;
    }
    return array;
}

public void PrintarArray(int[] array){
    foreach(int item in array){
        Console.WriteLine(item);
    }
}

int [] x = Dobro (new int[] {1,2,3,4,5});
PrintarArray(x);
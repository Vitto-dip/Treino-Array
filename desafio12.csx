public int Segundavalor (int[] notas){
    int valor = 0;
    int valor2 = 0;
    foreach(int item in notas){
        if(item > valor){
            valor = item;
        }
    }
    foreach(int item in notas){
        if(item > valor2 && item < valor){
            valor2 = item;
        }
    }
    
    
    return valor2;
}

int x = Segundavalor(new int[] {8,2,10,5,3});
Console.WriteLine(x);
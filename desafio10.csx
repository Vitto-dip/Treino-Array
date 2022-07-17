public int SomaArray (int[] notas){

    int soma = 0;
    foreach(int item in notas){
        soma = item + soma;
    }
    return soma;
}

int x = SomaArray(new int[] {2,5,8,7,3});
Console.WriteLine(x);
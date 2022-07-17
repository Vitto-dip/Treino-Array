public int Media(int[] notas){
    int soma = 0;
    foreach(int item in notas){
        soma = soma + item;
    }
    soma /= notas.Length;
    return soma;
}

int x = Media (new int[] {2,5,8,7,3});
Console.WriteLine(x);
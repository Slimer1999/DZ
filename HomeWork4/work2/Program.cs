/*
Заполняем массив случайными числами
*/
void f1(int[] mas)
{
    var rand = new Random();
    for (int i = 0; i<=mas.Length - 1; i++)
    {
        mas[i] = rand.Next(-99,100);
    }
}

/*
Выводит массив на экран
*/
void f2 (int[] mas)
{
    Console.Write("[ ");
    foreach(var n in mas)
    {
        Console.Write(n + " ");
    }
    Console.WriteLine("]");
}
/*
Возвращает сумму элементов массива
которые имеют нечётные номера
*/
int f3(int[] mas)
{
    int k = 0;
    for (int i = 0; i <=mas.Length -1; i++)
    {    
        if ( i % 2 == 1)
        {
            k = k + mas[i];
        }
    } 
    return k;
}




int[] mas= new int[10];
f1(mas);
f2(mas);
Console.Write(f3 (mas));

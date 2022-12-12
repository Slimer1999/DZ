/*
Заполняем массив случайными числами
*/
void f1(int[] mas)
{
    var rand = new Random();
    for (int i = 0; i<=mas.Length - 1; i++)
    {
        mas[i] = rand.Next(100,1000);
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
Вычисляет количество чётных элементов массива
*/
int f3(int[] mas)
{
    int k = 0;
    foreach (var elem in mas)
    {
        if (elem % 2 == 0)
        {
            k++;
        }   
    }  
    return k;
}



int[] m = new int[10];
f1(m);
f2(m);
Console.Write(f3(m));

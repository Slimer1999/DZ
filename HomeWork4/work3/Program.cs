/*
Возвращает введённое с клавиатуры 
число типпа int 
*/
int f1i (string invite)
{
    string ns;
    Console.Write(invite);
    ns = Console.ReadLine();
    return int.Parse(ns);
}
/*
Возвращает введённое с клавиатуры 
число типпа double 
*/
double f1d (string invite)
{
    string ns;
    Console.Write(invite);
    ns = Console.ReadLine();
    return double.Parse(ns);
}
/*
Заполняет массив числами 
с клавиатуры
*/
void f2 (double[] mas)
{
    for (int i = 0; i <= mas.Length -1; i++)
    {
        mas[i] = f1d("Введите элемент массива: ");
    }
}

/*
Возвращает минимальный 
элемент масива 
*/
double f3 (double[] mas)
{
    double small = mas[0];
    for (int i = 0;  i <=mas.Length -1; i++)
    {
        if (small > mas[i])
        {
            small = mas[i];
        }
    }
    return small;
}
/*
Возвращает максимальный 
элемент масива 
*/
double f4 (double[] mas)
{
    double big = mas[0];
    for (int i = 0;  i <=mas.Length -1; i++)
    {
        if (big < mas[i])
        {
            big = mas[i];
        }
    }
    return big;
}
/*
Выводит массив на экран
*/
void f5 (double[] mas)
{
    Console.Write("[ ");
    foreach(var n in mas)
    {
        Console.Write(n + " ");
    }
    Console.WriteLine("]");
}
int n = f1i("Введите длину массива: ");
double[] m = new double[n];
f2 (m);
f5(m);
double raznost = f4(m)-f3(m);
Console.WriteLine(raznost.ToString());

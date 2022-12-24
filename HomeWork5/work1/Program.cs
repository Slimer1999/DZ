int[] f1 ()
{
    string ns;  
    Console.WriteLine("Введите ряд чисел через пробел");
    ns = Console.ReadLine();
    string[] m1 = ns.Split(" "); 
    int[] m2 = new int[m1.Length];
    for (int i = 0; i<m1.Length; i++)
    {
        m2[i] = int.Parse(m1[i]);
    }    
    return m2;
}
int f2(int[] mas)
{
    int k = 0;
    foreach(var m in mas)
    {
        if (m>0)
        {
            k++;
        }
    
    }
    return k;
}
/*
Выводит массив на экран
*/
void f5 (int[] mas)
{
    Console.Write("[ ");
    foreach(var n in mas)
    {
        Console.Write(n + " ");
    }
    Console.WriteLine("]");
}




int[] m = f1();
f5(m); 
int k = f2(m);
Console.WriteLine(k);

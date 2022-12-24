int[] f1 (int stb)
{
    string ns;  
    Console.WriteLine("Введите " + stb + "чисел через пробел");
    ns = Console.ReadLine();
    string[] m1 = ns.Split(" "); 
    int[] m2 = new int[stb];
    for (int i = 0; i<stb; i++)
    {
        m2[i] = int.Parse(m1[i]);
    }    
    return m2;
}




string ns;
int str, stb;
Console.WriteLine("Введите количество строк и столбцов");
ns = Console.ReadLine();
str = int.Parse(ns);
ns = Console.ReadLine();
stb = int.Parse(ns);
int [,] m = new int[str,stb];
for (int i = 0; i < str; i++)
{
    int[] m1 = f1(stb);
    for (int j = 0; j < stb; j++)
    {
        m[i,j] = m1[j];
    }
}
Console.WriteLine();
for (int i = 0; i < str; i++)
{
    for (int j = 0; j < stb; j++)
    {
        Console.Write(m[i,j]+" ");
    }
    Console.WriteLine();
}
for (int i = 0; i < stb; i++)
{
    double sum = 0;
    double sr = 0;
    for (int j = 0; j < str; j++)
    {
        sum = sum + m[j,i];
    }
    sr = sum/str;
    Console.Write(sr + " ");
}


double[] f1 (int stb)
{
    string ns;  
    Console.WriteLine("Введите " + stb + "чисел через пробел");
    ns = Console.ReadLine();
    string[] m1 = ns.Split(" "); 
    double[] m2 = new double[m1.Length];
    for (int i = 0; i<m1.Length; i++)
    {
        m2[i] = double.Parse(m1[i]);
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
double [,] m = new double[str,stb];
for (int i = 0; i < str; i++)
{
    double[] m1 = f1(stb);
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



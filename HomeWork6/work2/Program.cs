double[] f1 (int stb)
{
    Random rnd = new Random();
    double[] m2 = new double[stb];
    for (int i = 0; i<stb; i++)
    {
        m2[i] = rnd.Next(10,21);
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
Console.WriteLine("Введите число");
ns = Console.ReadLine();
double n = double.Parse(ns);
int f = 0;
for (int i = 0; i < str; i++)
{
    for (int j = 0; j < stb; j++)
    {
        if (m [i,j] == n)
        {
            Console.WriteLine(i + " " + j);
            f = 1;
        }
    }
}
if (f == 0)
{
   Console.WriteLine("Такомво эдемента в массиве нету"); 
}

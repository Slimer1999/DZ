using System.Linq;

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

void f2(double[][] m,int str,int stb)
{
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < stb; j++)
        {                                                               
            Console.Write(m[i][j]+" ");
        }
        Console.WriteLine();
    }
}

string ns;
int str,stb;
Console.WriteLine("Введите количество строк и столбцов");
ns = Console.ReadLine();
str = int.Parse(ns);
ns = Console.ReadLine();
stb = int.Parse(ns);
double[][] mas = new double[str][];
for (int i = 0; i<str; i++)
{
    mas[i] = f1(stb);
}
f2 (mas,str,stb);
for (int i = 0; i<str; i++)
{
    Array.Sort(mas[i]);
    Array.Reverse(mas[i]);
}

Console.WriteLine();
f2 (mas,str,stb);

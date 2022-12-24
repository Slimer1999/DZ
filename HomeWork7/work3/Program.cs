int [] f1 (int stb)
{
    Random rnd = new Random();
    int[] m2 = new int[stb];
    for (int i = 0; i<stb; i++)
    {
        m2[i] = rnd.Next(10,21);
    }    
    return m2;
}

int [,] f2 (int str, int stb)
{
    int [,] m = new int[str,stb];
    for (int i = 0; i < str; i++)
    {
        int[] m1 = f1(stb);
        for (int j = 0; j < stb; j++)
        {
            m[i,j] = m1[j];
        }
    }
    return m;
}

void f3 (int [,] mas)
{
    int str = mas.GetUpperBound(0) + 1;
    int stb = mas.Length/str;
    Console.WriteLine();
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < stb; j++)
        {
            Console.Write(mas[i,j]+" ");
        }
        Console.WriteLine();
    }
}





int[,] f4(int[,] ma, int[,] mb)
    {       
        int stra = ma.GetUpperBound(0) + 1;
        int stba = ma.Length/stra;
        int strb = mb.GetUpperBound(0) + 1;
        int stbb = mb.Length/strb;
        var mc = new int[stra, stbb];
        for (var i = 0; i < stra; i++)
        {
            for (var j = 0; j < stbb; j++)
            {
                mc[i, j] = 0;
                for (var k = 0; k < stba; k++)
                {
                    mc[i, j] += ma[i, k] * mb[k, j];
                }
            }
        }
        return mc;
    }



string ns;
int stra, stba, strb, stbb;
Console.WriteLine("Введите количество  строк и столбцов первой матрицы");
ns = Console.ReadLine();
stra = int.Parse(ns);
ns = Console.ReadLine();
stba = int.Parse(ns);
int [,] ma = f2(stra,stba);
f3(ma);
Console.WriteLine("Введите количество  строк и столбцов второй матрицы");
ns = Console.ReadLine();
strb = int.Parse(ns);
ns = Console.ReadLine();
stbb = int.Parse(ns);
int [,] mb = f2(strb,stbb);
f3(mb);
if (stba!= strb)
{
    Console.WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");

}
else 
{
    int [,] m = f4(ma, mb);
    f3(m);  
}
         

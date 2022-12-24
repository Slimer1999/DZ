double[] f1 ()
{
    string ns;  
    Console.WriteLine("Введите кофициенты уравнений");
    ns = Console.ReadLine();
    string[] m1 = ns.Split(" "); 
    double[] m2 = new double[m1.Length];
    for (int i = 0; i<m1.Length; i++)
    {
        m2[i] = double.Parse(m1[i]);
    }    
    return m2;

}
double f2 (double k1, double b1, double k2, double b2)
{
    double x0 = (b2 - b1)/(k1-k2);
    return x0;
}
double f3 (double k1, double b1, double k2, double b2)
{
    double y0 = k1 * (b2 - b1)/(k1-k2) + b1;
    return y0;
}
double b1,b2,k1,k2;
k1 = 0;
b1 = 0;
b2 = 0;
k2 = 0;
double[] m = f1 ();
k1 = m[0];
b1 = m[1];
k2 = m[2];
b2 = m[3];
if (k1 == k2)
{
    Console.WriteLine("нет точки пересечения");
} 
else
{
    double x0 = f2(k1,b1,k2,b2);
    double y0 = f3(k1,b1,k2,b2);
    Console.WriteLine(x0 + " " + y0);
}

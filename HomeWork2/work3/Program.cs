string ns;
int n;
double k;
Console.WriteLine("Введите число");
ns = Console.ReadLine();
n = int.Parse(ns);
for (int i = 1; i <= n; i++)
{
    k = Math.Pow((i),3);
    Console.Write(k + " ");
}


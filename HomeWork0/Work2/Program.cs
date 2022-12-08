int n1;
int n2;
int n3;
string ns;
Console.WriteLine("Ввод трёх чисел");
ns = Console.ReadLine();
n1 = int.Parse(ns);
ns = Console.ReadLine();
n2 = int.Parse(ns);
ns = Console.ReadLine();
n3 = int.Parse(ns);
if ((n1 > n2) && (n1 > n3))
{
    Console.WriteLine(n1);
}
if ((n2 > n1) && (n2 > n3))
{
    Console.WriteLine(n2);
}
if ((n3 > n2) && (n3 > n1))
{
    Console.WriteLine(n3);
}

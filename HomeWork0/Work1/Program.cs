
int n1;
int n2;
string ns;
Console.WriteLine("Ввод двух чисел");
ns = Console.ReadLine();
n1 = int.Parse(ns);
ns = Console.ReadLine();
n2 = int.Parse(ns);

if (n1 > n2) 
{
    Console.WriteLine("Max = " + n1);
}
else
{
    Console.WriteLine("Max = " + n2);
}

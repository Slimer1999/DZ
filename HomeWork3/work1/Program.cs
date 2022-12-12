string ns;
int A;
int B;
int k;
Console.WriteLine("Введите 2 числа");
ns = Console.ReadLine();
A = int.Parse(ns);
ns = Console.ReadLine();
B = int.Parse(ns);
k = 1;
for (int i = 1; i <= B; i++)
{
    k = k*A;
}
Console.Write(k);

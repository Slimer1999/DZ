string ns;
int n;
Console.WriteLine("Введите трёх значное число");
ns = Console.ReadLine();
n = int.Parse(ns);
n = n/10;
n = n%10;
Console.WriteLine(n);

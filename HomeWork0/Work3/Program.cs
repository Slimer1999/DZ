int n1;
string ns;
Console.WriteLine("Введите число");
ns = Console.ReadLine();
n1 = int.Parse(ns);
if (n1 % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

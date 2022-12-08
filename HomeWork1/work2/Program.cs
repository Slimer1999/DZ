string ns;
int n;
Console.WriteLine("Введите число с клавиатуры");
ns = Console.ReadLine();
if (ns.Length > 2)
{
    Console.WriteLine(ns[2]);
}
else 
{
    Console.WriteLine("Такой цифры нет");
}





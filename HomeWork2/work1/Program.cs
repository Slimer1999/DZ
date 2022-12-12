string ns;
int n;
Console.WriteLine("Введите пятизначное число");
ns = Console.ReadLine();
if ((ns[0] == ns[4]) && (ns[1] == ns[3]))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

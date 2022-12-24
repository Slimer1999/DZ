int f1(int ch1, int ch2)
{
    if (ch1 == 0)
    {
        return ch2 +1;
    }
    if (ch2 == 0)
    {
        return f1(ch1 - 1,1);
    }
    if (ch1 > 0 && ch2 > 0)
    {
        return f1(ch1 - 1,f1(ch1,ch2 - 1));
    }
    return 0;
}



string ns;
int n1,n2;
Console.WriteLine("Введите два числа");
ns = Console.ReadLine();
n1 = int.Parse(ns);
ns = Console.ReadLine();
n2 = int.Parse(ns);
int r = f1(n1, n2);
Console.WriteLine(r);

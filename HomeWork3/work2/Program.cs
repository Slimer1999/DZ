string ns;
int s;
int chastnoe;
int cifra;
Console.WriteLine("Введите число");
ns = Console.ReadLine();
chastnoe = int.Parse(ns);
s = 0;
while (chastnoe > 0) 
{
    cifra = chastnoe % 10;
    s = s + cifra;
    chastnoe = chastnoe / 10;
}
Console.Write(s);


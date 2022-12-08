int n1;
string ns;
Console.WriteLine("Введите число");
ns = Console.ReadLine();
n1 = int.Parse(ns);
for (int i = 1; i<=n1; i++)
{
    if (i % 2 == 0)
    {
        if(i == (n1 - 1)||(i == n1))
        {
            Console.WriteLine(i);
        }
        else
        {
             Console.Write(i + ", ");
        }
       
        
    }
}

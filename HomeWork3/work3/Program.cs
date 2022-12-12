var rand = new Random();
int[]  n1 = new int[8];
for (int i = 0;  i < n1.Length; i++) 
{
    n1[i] = rand.Next(100);
}
Console.Write("[ ");
foreach(var n in n1)
{
    Console.Write(n + " ");
}
Console.WriteLine("]");


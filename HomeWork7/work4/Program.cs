int n = 4;
int a = 0;
int[,,] m = new int [n,n,n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < n; k++)
        {
            m[i,j,k] = a++;
        }
    }
}


for (int i = 0; i < n; i++)
{
    for (int k = 0; k < n; k++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(m[i,j,k]+ "("+i+j+k+")");
        }
        Console.WriteLine();
    }
}

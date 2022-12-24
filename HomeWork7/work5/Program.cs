void f1 (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}



int n = 4;
int[,] s = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= s.GetLength(0) * s.GetLength(1))
{
  s[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < s.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= s.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > s.GetLength(1) - 1)
    j--;
  else
    i--;
}

f1(s);




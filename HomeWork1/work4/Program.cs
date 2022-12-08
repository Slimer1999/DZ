/* - Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число 
квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/
string ns;
string ns1;
int n1;
int n2;
int k1;
Console.WriteLine("Введите два числа");
ns = Console.ReadLine();
n1 = int.Parse(ns);
ns1 = Console.ReadLine();
n2 = int.Parse(ns1);
//если первое число < второго числа то мы первое число меняем местами со вторым
if (n1 < n2)
{
    k1 = n1;
    n1 = n2;
    n2 = k1;
}
    //если n2*n2 = n1 то Да
    if(n2*n2 == n1)
    {
         Console.WriteLine("Да");
    }
    //Иначе Нет
    else
    {
        Console.WriteLine("Нет");
    }


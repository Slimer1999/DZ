﻿string ns;
double x1,x2,y1,y2,z1,z2;
double S;
Console.WriteLine("Введите координаты первой точки");
ns = Console.ReadLine();
x1 = int.Parse(ns);
ns = Console.ReadLine();
y1 = int.Parse(ns);
ns = Console.ReadLine();
z1 = int.Parse(ns);
Console.WriteLine("Введите координаты второй точки");
ns = Console.ReadLine();
x2 = int.Parse(ns);
ns = Console.ReadLine();
y2 = int.Parse(ns);
ns = Console.ReadLine();
z2 = int.Parse(ns);
S = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)+ Math.Pow((z2-z1),2));
S = Math.Round(S,2);
Console.WriteLine(S);
/*Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 3D пространстве.*/

Console.Clear();
Console.Write("Введите Х1: ");
int X1=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y1: ");
int Y1=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Z1: ");
int Z1=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Х2: ");
int X2=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y2: ");
int Y2=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Z2: ");
int Z2=Convert.ToInt32(Console.ReadLine());

double D=Math.Sqrt(Math.Pow(X1-X2, 2)+Math.Pow(Y1-Y2, 2)+Math.Pow(Z1-Z2, 2));

Console.WriteLine($"D={D:f2}");

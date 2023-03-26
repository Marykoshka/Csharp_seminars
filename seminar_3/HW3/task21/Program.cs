// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53 AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.Write("введите Х1: ");
double xa = double.Parse(Console.ReadLine());
Console.Write("введите Y1: ");
double ya = double.Parse(Console.ReadLine());
Console.Write("введите Z1: ");
double za = double.Parse(Console.ReadLine());

Console.Write("введите Х2: ");
double xb = double.Parse(Console.ReadLine());
Console.Write("введите Y2: ");
double yb = double .Parse(Console.ReadLine());
Console.Write("введите Z2: ");
double zb = double.Parse(Console.ReadLine());

double lengthAB(double xa, double ya, double za, double xb, double yb, double zb)
{
    double ab = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
    return Math.Round(ab, 2, MidpointRounding.ToNegativeInfinity);
}

double res = lengthAB(xa, ya, za, xb, yb, zb);
Console.WriteLine(res);



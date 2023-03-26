// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
Console.WriteLine("введите Х1: ");
double xa = double.Parse(Console.ReadLine());
Console.WriteLine("введите Y1: ");
double ya = double.Parse(Console.ReadLine());

Console.WriteLine("введите Х2: ");
double xb = double.Parse(Console.ReadLine());
Console.WriteLine("введите Y2: ");
double yb = double .Parse(Console.ReadLine());

double ab = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));

Console.WriteLine(Math.Round(ab, 2, MidpointRounding.ToNegativeInfinity));


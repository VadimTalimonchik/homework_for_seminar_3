// Задача 21.
// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату XA: ");
int XA = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату YA: ");
int YA = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату ZA: ");
int ZA = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату XB: ");
int XB = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату YB: ");
int YB = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату ZB: ");
int ZB = int.Parse(Console.ReadLine()!);

// double AB = Math.Sqrt((XB - XA) * (XB - XA) + (YB - YA) * (YB - YA) + (ZB - ZA) * (ZB - ZA));

double AB = Math.Sqrt(Math.Pow((XB - XA), 2) + Math.Pow((YB - YA), 2) + Math.Pow((ZB - ZA), 2));

void distance(double result)
{
    Console.Write($"Расстояние между точками А и В равно: {result}");
}
distance(AB);

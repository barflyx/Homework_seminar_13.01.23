/*
Задача 21
Напишите программу, 
которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double GetСoordinates(int ax, int ay, int az, int bx, int by, int bz)
{
    double res = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));
    return Math.Round(res, 2);
}

Console.WriteLine("Введите координаты 1-ой точки: ");
Console.Write("AX: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("AY: ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.Write("AZ: ");
int aZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты 2-ой точки: ");
Console.Write("BX: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("BY: ");
int bY = Convert.ToInt32(Console.ReadLine());
Console.Write("BZ: ");
int bZ = Convert.ToInt32(Console.ReadLine());

double result = GetСoordinates(aX, aY, aZ, bX, bY, bZ);
Console.WriteLine($"Расстояние между точками: {result}");



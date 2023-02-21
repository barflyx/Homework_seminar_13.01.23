/*Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double GetCoordinatesX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return Math.Round(x, 1);
}

double GetCoordinatesY(double b1, double k1, double b2, double k2, double x)
{
    double y = (x * (k1 + k2) + b1 + b2) / 2;
    return Math.Round(y, 1);
}

Console.WriteLine("Введите координаты прямых."); //везде тип double так как пользователь может ввести вещественное число, а условие задачи не исключает это.

Console.Write("Введите b1: ");
double userB1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите K1: ");
double userK1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double userB2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double userK2 = Convert.ToDouble(Console.ReadLine());

if (userB1 == userB2 && userK1 == userK2) Console.WriteLine($"Прямые совпадают!");
else if (userK1 == userK2) Console.WriteLine($"Прямые паралельны!");
else
{
    double coordinatesX = GetCoordinatesX(userB1, userK1, userB2, userK2);
    double coordinatesY = GetCoordinatesY(userB1, userK1, userB2, userK2, coordinatesX);

    Console.WriteLine($"Координаты точки пересечения ({coordinatesX}, {coordinatesY})");
}


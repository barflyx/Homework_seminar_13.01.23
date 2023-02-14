/*
Задача 25: Напишите цикл, 
который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

double GetResult(double num, double deg)
{
    double res = num;
    for (int i = 1; i < deg; i++)
    {
        res *= num;
    }
    return res;
}

Console.Write("Введите первое число: ");
double userNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите положительное целое число: ");
string? userDegree = Console.ReadLine();

int numberDegree;
bool res = int.TryParse(userDegree, out numberDegree);

while (numberDegree <= 0 || !res)
{
    Console.Write("Степень должна быть натуральным числом. Введите положительное целое число: ");
    userDegree = Console.ReadLine();
    res = int.TryParse(userDegree, out numberDegree);
}

double result = GetResult(userNumber, numberDegree);
Console.WriteLine($"{userNumber} в степени {numberDegree} = {result}.");
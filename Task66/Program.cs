/*
Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int NaturalNumbers(int m, int n)
{
    if (m == n) return m;
    if (m > n)
    {
        return m + NaturalNumbers(m - 1, n);
    }
    else
    {
        return m + NaturalNumbers(m + 1, n);
    }
}

Console.Write("Введите первое натуральное число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе натуральное число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

while (numberOne <= 0 || numberTwo <= 0)
{
    Console.WriteLine("Вы ввели неверное число!");

    Console.Write("Введите первое натуральное число: ");
    numberOne = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите второе натуральное число: ");
    numberTwo = Convert.ToInt32(Console.ReadLine());
}

int result = NaturalNumbers(numberOne, numberTwo);
Console.WriteLine(result);
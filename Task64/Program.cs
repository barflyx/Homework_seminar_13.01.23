/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
9Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void NaturalNumbers(int num, int firstValue)
{
    if (num == 0)
    {
        Console.Write('"');
        return;
    }
    if (num == firstValue)
    {
        Console.Write($"N = {num} -> \"{num}");
    }
    else Console.Write($", {num}");
    NaturalNumbers(num - 1, firstValue);
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number <= 0)
{
    Console.WriteLine("Вы ввели неправильное значение! Введите число больше 0: ");
    number = Convert.ToInt32(Console.ReadLine());
}

NaturalNumbers(number, number);
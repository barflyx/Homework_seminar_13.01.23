/*
Задача 4: Напишите программу, 
которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите число №1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number1 < number2)
{
    max = number2;
}
if (number2 < number3)
{
    max = number3;
}

Console.WriteLine("Максимальное число из введенных -> " + max);
/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/


bool GetAnswer(int num) 
{
return num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10;
}

Console.Write("Введите пятизначное положительное натуральное число:  ");
int Number = Convert.ToInt32(Console.ReadLine());

while (Number < 0 || Number > 99999 || Number < 10000)
{
    Console.Write("Вы ввели неправильное число. Введите пятизначное положительное натуральное число: ");
    Number = Convert.ToInt32(Console.ReadLine());
}

bool result = GetAnswer(Number);
Console.WriteLine(result ? $"Число {Number} палиндром." : $"Число {Number} не палиндром.");


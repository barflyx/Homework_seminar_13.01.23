/*
Задача 27: Напишите программу,
которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int GetSumNumbers(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber > -10 && userNumber < 10)
{
    Console.WriteLine($"Вы ввели цифру {userNumber}, не число!");
}
else
{
    int result = userNumber < 0 ? GetSumNumbers(-userNumber) : GetSumNumbers(userNumber);
    Console.WriteLine($"Сумма цифр числа {userNumber}: {result}.");
}

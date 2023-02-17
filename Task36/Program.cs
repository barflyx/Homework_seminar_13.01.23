/*
Задача 36: 
Задайте одномерный массив,
заполненный случайными числами. Найдите сумму элементов,
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] GenerateArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

string PrintArray(int[] arr)
{
    string str = "[";
    for (int i = 0; i < arr.Length; i++)
    {
        if (str == "[") str += arr[i];
        else str += $", {arr[i]}";
    }
    str += "]";
    return str;

}

int GetSumEvenNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

int[] arrayNumbers = GenerateArray(10, -20, 20);
int countEvenNumbers = GetSumEvenNumbers(arrayNumbers);
Console.WriteLine($"В массиве {PrintArray(arrayNumbers)} сумма чисел стоящих на нечетных позициях равна {countEvenNumbers}.");
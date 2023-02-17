/* 
Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементоv массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/

double[] GenerateDoubleArray(int length, int min, int max)
{
    double[] array = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return array;
}

string PrintArray(double[] arr)
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

double GetMaxNumber(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
    }
    return max;
}

double GetMinNumber(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
    }
    return min;
}

double GetDifferenceNumbers(double max, double min)
{
    return Math.Round(max - min, 1);
}

double[] arrayNumbers = GenerateDoubleArray(10, 0, 20);
double maxNumber = GetMaxNumber(arrayNumbers);
double minNumber = GetMinNumber(arrayNumbers);
double differenceNumbers = GetDifferenceNumbers(maxNumber, minNumber);
Console.WriteLine($"В массиве {PrintArray(arrayNumbers)} разница большего и меньшего числа равна {differenceNumbers}.");

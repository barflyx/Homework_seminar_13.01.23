/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] GenerateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

string PrintMatrix(int[,] matrix)
{
    string str = string.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        str += "[";
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == matrix.GetLength(1) - 1) str += $" {matrix[i, j],3} ";
            else str += $" {matrix[i, j],3}, ";
        }
        str += "]\n";
    }
    return str;

}

int GetMinSumInRows(int[,] matrix)
{
    int indexRowWithMinSum = 0;
    int sumRows = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int tmpSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            tmpSum += matrix[i, j];
        }
        if (i == 0) sumRows = tmpSum;
        else
        {
            if (tmpSum < sumRows)
            {
                sumRows = tmpSum;
                indexRowWithMinSum = i;
            }
        }
    }
    return indexRowWithMinSum;
}

int[,] matrixNumbers = GenerateMatrix(4, 4, 0, 20);
Console.WriteLine($"До перемены строк - \n{PrintMatrix(matrixNumbers)}");

int minSumInRows = GetMinSumInRows(matrixNumbers);
Console.WriteLine($"Минимальная сумма в {minSumInRows + 1} строке.");
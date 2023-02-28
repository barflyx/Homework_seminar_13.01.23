/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] GenerateSpiralMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int count = 1;
    int i = 0;
    int j = 0;
    matrix[i, j] = count;
    while (count <= matrix.Length)
    {
        while (j + 1 < matrix.GetLength(1) && matrix[i, j + 1] == 0)
        {
            j++;
            matrix[i, j] = ++count;
        }
        while (i + 1 < matrix.GetLength(0) && matrix[i + 1, j] == 0)
        {
            i++;
            matrix[i, j] = ++count;
        }
        while (j - 1 >= 0 && matrix[i, j - 1] == 0)
        {
            j--;
            matrix[i, j] = ++count;
        }
        while (i - 1 >= 0 && matrix[i - 1, j] == 0)
        {
            i--;
            matrix[i, j] = ++count;
        }
        if (count == matrix.Length) count++;
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

int[,] matrixNumbers = GenerateSpiralMatrix(4, 4);
Console.WriteLine(PrintMatrix(matrixNumbers));
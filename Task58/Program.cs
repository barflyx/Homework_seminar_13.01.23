/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] GetMultiMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixMulti = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrixMulti.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMulti.GetLength(1); j++)
        {
            // c ij​=a i1​b 1j​+a i2​b 2j​+...+a in​b nj​. 
            matrixMulti[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrixMulti[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrixMulti;
}

int[,] matrixNumbersOne = GenerateMatrix(4, 4, 0, 10);
Console.WriteLine($"Матрица 1 - \n{PrintMatrix(matrixNumbersOne)}");

int[,] matrixNumbersTwo = GenerateMatrix(4, 4, 0, 10);
Console.WriteLine($"Матрица 2 - \n{PrintMatrix(matrixNumbersTwo)}");

if (matrixNumbersOne.GetLength(1) == matrixNumbersTwo.GetLength(0))
{
    int[,] multiMatrix = GetMultiMatrix(matrixNumbersOne, matrixNumbersTwo);
    Console.WriteLine($"Приизведение матриц - \n{PrintMatrix(multiMatrix)}");
}
else
{
    Console.WriteLine("Нельзя найти произведение матриц");
}
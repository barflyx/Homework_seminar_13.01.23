/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Например, задан массив размером 2 x 2 x 2.
Результат:
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
*/


void GenerateMatrix(int[,,] matrix, int min, int max)
{
    int[] memoryNumbers = new int[matrix.Length];
    int count = 0;
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int tmpNum = rnd.Next(min, max + 1);
                while (memoryNumbers.Contains(tmpNum))
                {
                    tmpNum = rnd.Next(min, max + 1);
                }
                matrix[i, j, k] = tmpNum;
                memoryNumbers[count++] = tmpNum;
            }
        }
    }
}

string PrintMatrix(int[,,] matrix)
{
    string str = string.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k == matrix.GetLength(1) - 1) str += $" {matrix[i, j, k],3}({i},{j},{k})";
                else str += $" {matrix[i, j, k],3}({i},{j},{k}), ";
            }
        }
        str += "\n";
    }
    return str;

}

int[,,] matrixNumbers = new int[4, 4, 4];
int minNumber = 10;
int maxNumber = 99;
if (matrixNumbers.Length > maxNumber - minNumber)
{
    Console.WriteLine("Нельзя сотворить матрицу данного размера! Количесво элементов матрицы превосходит количество чисел в промежутке от минимума к максимуму!");
}
else
{
    GenerateMatrix(matrixNumbers, minNumber, maxNumber);
    Console.WriteLine(PrintMatrix(matrixNumbers));
}
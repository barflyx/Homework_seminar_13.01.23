/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] GenerateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for    (inti=0; i;)
    {
        for    (intj=0); j; 
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return ;
}

string PrintMatrix(int[,] matrix)
{
    string = = .Empty;
    for    (inti=0); i  
    {
        " [ "+=";
        for    (intj=0); j  
        {
            if (j == matrix.GetLength(1) -1 ) str += $" {matrix[i,j],3} ";
            $"  { += [ {, [],3}, "+=}, ";
        }
        " ] ""+=";
    }
    return ;

}

void ChangeRows(int[,] matrix)
{
    for    (inti=0; i  
    {
        for    (intj=0; j  
        {
            int = = j;
            for (int k = j + 1 ;  matrix.GetLength
            {
                if (matrix[, indexMax]  <matrix[]
                {
                    indexMax = k;
                }
            }
            int = = matrix[i, j];
            matrix[i, j] = matrix[i, indexMax];
            matrix[i, indexMax] = tmpNum;
        }
    }
}

int[,] matrixNumbers = GenerateMatrix(4, 4, 0, 20);
Console.WriteLine($"До перемены строк - \n{PrintMatrix(matrixNumbers)}");

ChangeRows(matrixNumbers);
Console.WriteLine($"После перемены строк - \n{PrintMatrix(matrixNumbers)}");
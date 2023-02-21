/* 
Задача 41: 
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int[] GenerateArray(int length)
{
 int[] array = new int[length];
 for (int i = 0; i < length; i++)
     {
 Console.Write($"Введите {i + 1} число: ");
 array[i] = Convert.ToInt32(Console.ReadLine());
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

 int GetCountPositiveNumbers(int[] array)
 {
 int count = 0;
for (int i = 0; i < array.Length; i++)
     {
 if (array[i] > 0) count++;
     }
 return count;
 }

Console.Write("Сколько числел вы будете вводить? - ");
int userSizeArray = Convert.ToInt32(Console.ReadLine());

int[] arrayNumbers = GenerateArray(userSizeArray);

int countPositiveNumbers = GetCountPositiveNumbers(arrayNumbers);
Console.WriteLine($"В массиве {PrintArray(arrayNumbers)} {countPositiveNumbers} положительных чисел(ла).");
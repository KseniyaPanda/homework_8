/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/

// получить числа с консоли
int GetNumber(string message)
{
   int result = 0;
   while (true)
   {
      Console.WriteLine(message);
      if (int.TryParse(Console.ReadLine(), out result) && result > 0)
      {
         break;
      }
      else
      {
         Console.WriteLine("Ввели не число");
      }
   }
   return result;
}

// задать матрицу и заполнить ее числами
int[,] GetMatrix(int m, int n)
{
   int[,] matrix = new int[m, n];
   Random rnd = new Random();
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrix[i, j] = rnd.Next(1, 10);
      }
   }
   return matrix;
}

// распечатать матрицу
void PrintMatrix(int[,] matrix)
{
   Console.WriteLine();
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         Console.Write($"{matrix[i, j]} ");
      }
      Console.WriteLine();
   }
}

void MinSum(int[,] matrix)
{
   int minNum = 0;
   int minSum = 0;
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      int sum = 0;
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         sum = sum + matrix[i, j];
      }
      //Console.WriteLine($"Сумм {i + 1} стр {sum}\n");
      if (i == 0)
      {
         minSum = sum;
      }
      else if (sum < minSum)
      {
         minSum = sum;
         minNum = i;
      }
   }
   Console.Write($"№ строки с мин суммой: {minNum + 1}");
}

int m = GetNumber("Введите количество строк");
int n = GetNumber("Введите количество столбцов");

int[,] matrix = GetMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine("");
MinSum(matrix);

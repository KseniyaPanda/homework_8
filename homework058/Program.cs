/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет 
находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
( 1 2 )   ( 11 22 ) = ( 1*11 + 2*33   1*22 + 2*44 ​)
( 3 4 )   ( 33 44 ) = ( 3*11 + 4*33   3*22 + 4*44 )
*/

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

void Multiplication(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
   for (int i = 0; i < resultMatrix.GetLength(0); i++)
   {
      for (int j = 0; j < resultMatrix.GetLength(1); j++)
      {
         int sum = 0;
         for (int k = 0; k < firstMatrix.GetLength(1); k++)
         {
            sum = sum + firstMatrix[i, k] * secondMatrix[k, j];
         }
         resultMatrix[i, j] = sum;
      }
   }
}

int m = GetNumber("Введите количество строк 1 матрицы");
int n = GetNumber("Введите количество столбцов 1 матрицы и строк 2 матрицы");
int p = GetNumber("Введите количество столбцов 2 матрицы");

int[,] firstMatrix = GetMatrix(m, n);
int[,] secondMatrix = GetMatrix(n, p);
int[,] resultMatrix = new int[m, p];

PrintMatrix(firstMatrix);
PrintMatrix(secondMatrix);
Multiplication(firstMatrix, secondMatrix, resultMatrix);
PrintMatrix(resultMatrix);

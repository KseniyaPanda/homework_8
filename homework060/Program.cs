/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных 
чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
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

int[,,] GetMatrix(int m, int n, int k)
{
   int[,,] matrix = new int[m, n, k];
   Random rnd = new Random((int)DateTime.Now.Ticks);
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         for (int z = 0; z < matrix.GetLength(2); z++)
         {
            matrix[i, j, z] = rnd.Next(100, 1000);
         }
      }
   }
   return matrix;
}

void PrintMatrix(int[,,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         Console.WriteLine();
         for (int z = 0; z < matrix.GetLength(2); z++)
         {
            Console.Write($"{matrix[i, j, z]} ({i},{j},{z})  ");
            //Console.Write($"{matrix[i, j, z]},");
         }
      }
   }
}

int m = GetNumber("Введите X размер матрицы");
int n = GetNumber("Введите Y размер матрицы");
int k = GetNumber("Введите Z размер матрицы");

int[,,] matrix = GetMatrix(m, n, k);

PrintMatrix(matrix);

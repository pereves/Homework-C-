// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

void FillArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0,10);
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}
void CompositionMatrix(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
  for (int i = 0; i < matrix3.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
      matrix3 [i,j] = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        matrix3 [i,j] += matrix1[i,k] * matrix2[k,j];
      }
      Console.Write($"{matrix3[i,j]} ");
    }
    Console.WriteLine();
  }
}
int [,] matrix1 = new int [2,2];
int [,] matrix2 = new int [2,2];
int [,] matrix3 = new int [2,2];
Console.WriteLine("Первая матрица: ");
FillArray(matrix1);
Console.WriteLine("Вторая матрица: ");
FillArray(matrix2);
Console.WriteLine("Произведение матриц: ");
CompositionMatrix(matrix1,matrix2,matrix3);
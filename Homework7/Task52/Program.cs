// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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
void Sum(int [,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        Console.Write($"{sum/2} ");
    }
}
int [,] matrix = new int [4,3];
FillArray(matrix);
Sum(matrix);
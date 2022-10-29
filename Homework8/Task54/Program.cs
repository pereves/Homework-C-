// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void FillArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0,10);
        }
    }
}
void Sorting(int [,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < numbers.GetLength(1) - 1; z++)
            {
                if (numbers[i, z] < numbers[i, z + 1])
                {
                    int temp = 0;
                    temp = numbers[i, z];
                    numbers[i, z] = numbers[i, z + 1];
                    numbers[i, z + 1] = temp;
                }
            }
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
int [,] matrix = new int [3,4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("Массив отсортирован по убыванию:");
Sorting(matrix);
PrintArray(matrix);
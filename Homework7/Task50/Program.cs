// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

void FillArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0,100);
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}
int [,] matrix = new int [4,3];
FillArray(matrix);
Console.Write("Введите номер строки: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int j = Convert.ToInt32(Console.ReadLine());
if (i > matrix.GetLength(0) || j > matrix.GetLength(1))
{
    Console.WriteLine("Такого элемента в массиве нет");
}
else
{
    Console.WriteLine($"Элемент находящийся в {i} строке и {j} столбце {matrix[i-1,j-1]}");
}
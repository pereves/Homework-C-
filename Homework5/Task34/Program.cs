// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void IntroArray(int[] number)
{
    int lenght = number.Length;
    for (int i = 0; i < lenght; i++)
    {
        number[i] = new Random().Next(100,999);
        Console.Write($"{number[i]} ");
    }
}
int AnEvenNumber(int [] num)
{
    int len = num.Length;
    int count = 0;
    for (int index = 0; index < len; index++)
    {
        if (num[index]%2 == 0)
        {
            count ++;
        }
    }
    return count;
}
int [] array = new int [4];
IntroArray(array);
Console.WriteLine($"\r\nКоличество четных элементов в массиве {AnEvenNumber(array)}");
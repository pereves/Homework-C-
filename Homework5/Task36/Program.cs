//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void IntroArray(int[] number)
{
    int lenght = number.Length;
    for (int i = 0; i < lenght; i++)
    {
        number[i] = new Random().Next(-100, 100);
        Console.Write($"{number[i]} ");
    }
}
int OddNumber(int [] num)
{
    int len = num.Length;
    int sum = 0;
    for (int index = 1; index < len; index += 2)
    {
        sum = sum + num[index];
    }
    return sum;
}
int [] array = new int [4];
IntroArray(array);
Console.WriteLine($"\r\nСумма элементов, стоящих на нечётных позициях {OddNumber(array)}");

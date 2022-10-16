// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void IntroArray(double[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = new Random().Next(0, 100);
        Console.Write($"{number[i]} ");
    }
}
double Diffrence(double [] num)
{
    double min = num[0];
    double max = num[0];
    for (int index = 0; index < num.Length; index ++)
    {
        if (num[index] > max)
        {
            max = num[index];
        }
        if (num[index] < min)
        {
            min = num[index];
        }
    }
    return max-min;
}
double [] array = new double [4];
IntroArray(array);
Console.WriteLine($"\r\nРазница между максимальным и минимальным элементом массива {Diffrence(array)}");

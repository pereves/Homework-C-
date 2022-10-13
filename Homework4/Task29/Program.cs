// Напишите метод, который задаёт массив из 8 элементов и выводит их на экран.

void IntroArray(int[] number)
{
    int lenght = number.Length;
    for (int i = 0; i < lenght; i++ )
    {
        number[i] = new Random().Next(1,10);
    }
}
void PrintArray(int[] num)
{
    Console.Write("[");
    int count = num.Length;
    for (int index = 0; index < count; index++)
    {
        Console.Write($"{num[index]}, ");
    }
    Console.Write("]");
}

int [] array = new int [8];
IntroArray(array);
PrintArray(array);
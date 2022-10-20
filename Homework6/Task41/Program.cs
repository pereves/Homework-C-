//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

void IntroArray(int[] number)
{
    for(int i = 0; i < number.Length; i++)
    {
        Console.Write("Введите число: ");
        number[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int GetCount(int[] num)
{
    int count = 0;
    for(int index = 0; index < num.Length; index++)
    {
        if(num[index] > 0)
        {
            count ++;
        }
    }
    return count;
}
int [] array = new int [5];
IntroArray(array);
Console.WriteLine($"Пользователь ввел больше нуля {GetCount(array)} числа");





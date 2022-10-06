//Напишите метод, который принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int ReadInt ()
{
    Console.Write("Введите цифру, обозначающую день недели: ");
    return Convert.ToInt32(Console.ReadLine());
}
int day = ReadInt();
void DayOfWeek ()
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Этот день выходной");
    }
    else if (day < 1 || day > 7)
    {
        Console.WriteLine("Это не день недели");
    }
    else{
        Console.WriteLine("Это будний день");
    }
}
DayOfWeek ();
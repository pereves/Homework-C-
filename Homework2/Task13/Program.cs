//Напишите метод, который выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ReadInt()
{
    Console.WriteLine("Ведите число");
    return Convert.ToInt32(Console.ReadLine());
}
int Num = ReadInt();
string NumText = Convert.ToString(Num);
void Output ()
{
    if (Num/100 == 0)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        Console.WriteLine("Третья цифра числа " + NumText[2]);
    }
}
Output ();
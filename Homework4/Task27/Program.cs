// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

int Intro()
{
    Console.Write("Ведите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
int GetSum(int num)
{
    int sum = 0;
    for (int i = 0; 0 < num; i++ )
    {
        sum = sum + num %10;
        num = num / 10;
    }
    return sum;

}
void Print (int num, int res)
{
    Console.WriteLine($"Сумма цифр в числе {num} равна {res}");
}
int num = Intro();
int s = GetSum(num);
Print(num, s);

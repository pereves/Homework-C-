// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int Enter(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int Pal(int a)
{
    int rev = 0;
    while (a > 0)
    {
        rev = rev * 10 + a % 10;
        a = a / 10;
    }
    return rev;
}
int num = Enter("Введите число: ");
if (num == Pal(num))
{
    Console.WriteLine("Число " + num + " явлется полиндромом");
}
else
{
    Console.WriteLine("Число " + num + " не явлется полиндромом");
}
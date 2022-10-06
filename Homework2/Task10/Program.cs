//Напишите метод, который принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int PrintSign()
{
    Console.Write("Введите трехзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    num /= 10;
    num %= 10;
    Console.WriteLine("Вторая цифра числа: " + num);
    return num;
}
PrintSign();
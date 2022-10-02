// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.WriteLine("Все четные числа от 1 до" + " " + N);
while (i <= N)
{
    if(i %2 == 0)
    {
        Console.WriteLine(i);
    }
    i += 1;
}

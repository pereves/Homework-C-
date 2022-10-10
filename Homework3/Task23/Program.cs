// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int GetN()
{
    Console.Write("Введите N: ");
    return Convert.ToInt32(Console.ReadLine());
}
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.WriteLine($"{array[i]}^3 = {Math.Pow(array[i], 3)}");
}
int N = GetN();
int [] array = new int [N];
for (int i = 0; i < N; i++)
{
    array [i] = i + 1;
}
Print(array);
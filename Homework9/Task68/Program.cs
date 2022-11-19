// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

int Akkerman(int M, int N)
{
    if (M == 0) return N + 1;                                   
    else if ((M > 0) && (N == 0)) return Akkerman(M - 1, 1); 
    else if ((M > 0) && (N > 0)) return Akkerman(M - 1, Akkerman(M, N - 1)); 
    else return N + 1;           
}
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({M},{N}) = {Akkerman(M, N)}"); 
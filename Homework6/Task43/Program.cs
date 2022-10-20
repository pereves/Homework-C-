// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

double GetMean(string text)
{
    Console.Write(text + ": ");
    return Convert.ToDouble(Console.ReadLine());
}
string CrossPoint (double b1, double b2, double k1, double k2)
{
    if (k1 == k2)
    {
        string point = ("прямые не пересекаются");
        return point;
    }
    else
    {
        double x = (b1-b2)/(k2-k1);
        double y = k1 * x + b1;
        string point = ($"({x};{y})");
        return point;
    }
}
double b1 = GetMean("b1");
double b2 = GetMean("b2");
double k1 = GetMean("k1");
double k2 = GetMean("k2");
Console.WriteLine($"Точка пересечения двух прямых {CrossPoint(b1,b2,k1,k2)}");
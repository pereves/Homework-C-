// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

double GetValue(string text)
{
    Console.Write(text + ": ");
    return Convert.ToDouble(Console.ReadLine());
}
double GetDistance(double ax, double ay, double az, double bx, double by, double bz)
{
    double x = Math.Pow(ax - bx, 2);
    double y = Math.Pow(ay - by, 2);
    double z = Math.Pow(az - bz, 2);
    double result = Math.Sqrt(x+y+z);
    return result;
}
void Print (double ax, double ay, double az, double bx, double by, double bz, double res)
{
    string output = $"|A({ax}, {ay}, {az}); B({bx}, {by}, {bz})| = {Math.Round(res, 2)}";
    Console.WriteLine (output);
}
double ax = GetValue ("ax");
double ay = GetValue ("ay");
double az = GetValue ("az");
double bx = GetValue ("bx");
double by = GetValue ("by");
double bz = GetValue ("bz");

double dis = GetDistance (ax, ay, az, bx, by, bz);
Print (ax, ay, az, bx, by, bz, dis);

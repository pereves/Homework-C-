//Напишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.

int Intro(string text)
{
    Console.WriteLine("Ведите значение: " + text);
    return Convert.ToInt32(Console.ReadLine());
}
int GetDegree(int A, int B)
{
    int step = A;
    for (int i = 1; i < B; i++ )
    {
        step = step * A;
    }
    return step;

}
void Print (int A, int B, int res)
{
    Console.WriteLine($"{A} в степени {B} = {res}");
}
int A = Intro("A");
int B = Intro("B");
int dig = GetDegree(A,B);
Print(A, B, dig);
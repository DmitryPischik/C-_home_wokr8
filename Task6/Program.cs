// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

float factorial(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j <= (n - i); j++) 
    {
        Console.Write(" "); 
    }
    for (int k = 0; k <= i; k++)
    {
        Console.Write(" "); 
        Console.Write(factorial(i) / (factorial(k) * factorial(i - k))); 
    }
    Console.WriteLine();
    Console.WriteLine(); 
}
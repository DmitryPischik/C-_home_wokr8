// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

void FillArray(int[,,] arr3d) // функция заполняет 3D массив не повторяющимися двузначными числами.
{
    int[] numbers = new int[0];
    int index = 0;
    for (int i = 0; i < arr3d.GetLength(0); i++)
    {
        for (int j = 0; j < arr3d.GetLength(1); j++)
        {
            for(int k = 0; k < arr3d.GetLength(2); k++)
            {                
                arr3d[i,j,k] = new Random().Next(10, 100);
                while(numbers.Contains(arr3d[i,j,k]) == true) arr3d[i,j,k] = new Random().Next(10, 100);
                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[index] = arr3d[i,j,k];      
                index++;
            }
        }
    }
}
void PrintArray(int[,,] arr3d) // функция просматривает 3D массив.
{
    for (int i = 0; i < arr3d.GetLength(0); i++)
    {
        for (int j = 0; j < arr3d.GetLength(1); j++)
        {
            for(int k = 0; k < arr3d.GetLength(2); k++)
            {
                Console.Write($"[{i}, {j}, {k}] = {arr3d[i, j, k]}   ");
            }
        }
    Console.WriteLine();
    }
}

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число k: ");
int k = int.Parse(Console.ReadLine() ?? "0");

int[,,] array = new int[m, n, k];
FillArray(array);
PrintArray(array);


// Составить частотный словарь элементов двумерного массива

// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

void PrintArray(int[,] matr) // функция просматривает массив.
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}   ");
        }
    Console.WriteLine();
    }
}
void PrintOneDimensionArray(int[] array)
{
    foreach (int element in array)
    {
        Console.Write($"{element} ");
    }
    Console.WriteLine();
}
void FillArray(int[,] matr) // функция заполняет массив.
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0, 10);
        }
    }
}
int[] SortToLower(int[] array) // функция упорядочивания по убыванию элементов одномерного массива.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for (int x = 0; x < array.GetLength(0) - 1; x++)
        {
            if (array[x] < array[x + 1])
            {
                int temp = array[x + 1];
                array[x + 1] = array[x];
                array[x] = temp;
            }
        }           
    }
    return array;
}
int[] ToOneDimension(int[,] array) // Функция переводит двумерный массив в одномерный.
{
    int[] newArray = new int[array.GetLength(0) * array.GetLength(1)];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[index] = array[i, j];
            index++;
        }
    }
    return newArray;
}
void FrequencyDict(int[] array)
{
    array = SortToLower(array);
    PrintOneDimensionArray(array);
    int step = 1;   
    int count = 1;  
    for (int i = 0; i < array.Length; i = i + step)
    {
        step = 1;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[i] == array[j]) 
            {
                count++;
                step = count;
            }
            else break;
        }
        Console.WriteLine($"{array[i]} встречается {count} раза");
        count = 1;
    }
}

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
PrintOneDimensionArray(ToOneDimension(array));
FrequencyDict(ToOneDimension(array));


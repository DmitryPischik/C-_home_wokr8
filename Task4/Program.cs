// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int min = array[0,0];
int column = 0, row = 0;
for(int i=0;i<m;i++)
{
    for(int j=0;j<n;j++)
    {
        if(min > array[i,j])
        {
            min = array[i,j];
            row = i;
            column = j;
        }
    }
}
Console.WriteLine($"{row} {column}");
Console.WriteLine();
int[,] newArray = new int[m -1, n - 1];
int iNew = 0, jNew = 0;
for (int i =0; i < m;i++)
{
    if(i != row)
    {
        for(int j= 0; j < n; j++)
        {
            if(j != column)
            {
                newArray[iNew, jNew] = array[i,j];   
                jNew++;             
            }                      
        }
        jNew = 0;
        iNew++;
    }    
}
PrintArray(newArray);

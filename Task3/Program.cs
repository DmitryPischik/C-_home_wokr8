//Найти произведение двух матриц
// Правило умножения матриц Произведение матрицы A размера m × n и матрицы B размера n × k — это матрица C
//размера m × k, в которой элемент cij ​равен сумме произведений элементов i строки матрицы A на соответствующие элементы j столбца матрицы B 

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
int[,] multiplyMatrixs(int[,]A, int[,]B)// функция находит произведение двух матриц.
{
    int[,] C = new int[A.GetLength(0), B.GetLength(1)];
    for(int i = 0; i < A.GetLength(0); i++)
    {
        for(int j =0; j < A.GetLength(1); j++)
        {
            for (int k =0; k < B.GetLength(1); k++)
            {
                C[i,k] = C[i,k] + (A[i,j] * B[j,k]);
            }
        }
    }
    return C;
}
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число k: ");
int k = int.Parse(Console.ReadLine() ?? "0");

int[,] matrixA = new int[m, n];
int[,] matrixB = new int[n, k];
int[,] matrixC = new int[m, k];

FillArray(matrixA);
FillArray(matrixB);
PrintArray(matrixA);
Console.WriteLine();
PrintArray(matrixB);
Console.WriteLine();
matrixC = multiplyMatrixs(matrixA, matrixB);
PrintArray(matrixC);



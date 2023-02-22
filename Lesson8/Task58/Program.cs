// Задача 58:
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:   Результирующая матрица будет:
// 2 4 | 3 4                   18 20
// 3 2 | 3 3                   15 18

using static System.Console;

int[,] CreateArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

// Метод, который проверяет возможность умножения матриц
bool PossibilityMultiplication(int[,] arrayA, int[,] arrayB)
{
    // Если количество столбцов в первой матрице не равно 
    // количеству строк во второй, умножение невозможно
    if (arrayA.GetLength(1) == arrayB.GetLength(0)) return true;
    return false;
}

// Метод умножающий матрицы
int[,] ProductOfTwoMatrix(int[,] arrayA, int[,] arrayB)
{
    // Количество строк в А
    int amountRowA = arrayA.GetLength(0);
    // Количество столбцов в А и строк в В
    int amountColARowB = arrayA.GetLength(1);
    // Количество столбцов в В
    int amountColB = arrayB.GetLength(1);
    // Создание пустой матрицы
    int[,] product = new int[amountRowA, amountColB];
    for (int i = 0; i < amountRowA; i++)
    {
        for (int j = 0; j < amountColB; j++)
        {
            for (int k = 0; k < amountColARowB; k++)
            {
                // умножение значений из столбцов первой матрицы на значения из строк второй
                product[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return product;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + " ");
        }
        WriteLine();
    }
    WriteLine();
}

int[,] a = { { 2, 4 }, { 3, 2 } }, b = { { 3, 4 }, { 3, 3 } };
WriteLine("Умножение тестовых матриц");
PrintArray(ProductOfTwoMatrix(a, b));

// Создание матриц случайных размеров и заполнение их случайными числами
int a1 = new Random().Next(2, 5), a2b1 = new Random().Next(2,5);
int b2 = new Random().Next(2, 5);
int[,] matrixOne = CreateArray(a1, a2b1, 2, 5);
int[,] matrixTwo = CreateArray(a2b1, b2, 2, 4);


if (PossibilityMultiplication(matrixOne, matrixTwo))
{
    int[,] matrixProduct = ProductOfTwoMatrix(matrixOne, matrixTwo);
    WriteLine("Умножение случайных матриц");
    PrintArray(matrixProduct);
}
else
{
    WriteLine(
@"Количество столбцов в первой матрице не равно количеству строк во второй
Умножение матриц невозможно");
}

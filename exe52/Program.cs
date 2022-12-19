/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

//задать матрицу и заполнить ее числами
int[,] GetMatrix(int n, int m)
{
    int[,] matrix = new int[3,4];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

//распечатать матрицу
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }  
}

int[,] matrix = GetMatrix(3,4);
PrintMatrix(matrix);

int FindSumm1(int[,] matrix)
{
    int summ1 = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        summ1 += matrix[i,0];
    }
    return summ1;
}

int FindSumm2(int[,] matrix)
{
    int summ2 = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        summ2 += matrix[i,1];
    }
    return summ2;
}

int FindSumm3(int[,] matrix)
{
    int summ3 = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        summ3 += matrix[i,2];
    }
    return summ3;
}

int FindSumm4(int[,] matrix)
{
    int summ4 = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        summ4 += matrix[i,3];
    }
    return summ4;
}

double num = FindSumm1(matrix);
double x = num / 3;
double num2 = FindSumm2(matrix);
double x2 = num2 / 3;
double num3 = FindSumm3(matrix);
double x3 = num3 / 3;
double num4 = FindSumm4(matrix);
double x4 = num4 / 3;
Console.WriteLine($"{x}; {x2}; {x3}; {x4} ");


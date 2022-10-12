/*
Console.Clear();

Console.Write("Введите m:");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n:");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите z:");
int z = int.Parse(Console.ReadLine()!);

int[,,] array = new int[m, n, z];
FillArray(array);
PrintArray(array);

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void FillArray(int[,,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = generator.Next(0, 100);
            }
        }
    }
}
*/

//Найти сумму элементов главной диагонали двумерного массива
/*
int sum = 0;
for (int i = 0; i < array.GetLength(0); i += 1)
{
for (int j = 0; j < array.GetLength(1); j += 1)
{
if (i == j)
{
sum += array[i,j];
}
}
}
return sum;
*/

/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/



Console.Write("Введите число строк m:");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число стобцов n:");
int n = int.Parse(Console.ReadLine()!);
double[,] generator = new double[m,n];
FillArray(generator);
PrintArray(generator);


void FillArray(double[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.NextDouble() * 100;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите m:");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n:");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int[10, 10];
FillArray(array);

if (n > array.GetLength(0) || m > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строчки и {m} столбца: {array[n-1,m-1]}");
}

PrintArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }Console.WriteLine();
}

void FillArray(int[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(0, 100);
        }
    }
}
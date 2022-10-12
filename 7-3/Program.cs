//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] array = new int[5, 5];
Random generator = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = generator.Next(0, 10);
    }
}
 
PrintArray(array);
Console.WriteLine();
PrintArray2(CalcSum(array));
 
double[] CalcSum(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    double sum;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j,i];
        }
        result[i] = sum / array.GetLength(0);
    }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void PrintArray2(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
}

// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.



int[,] FillArray(int numLine, int numColumns)         // Функция создания и заполнения двумерного массива
{
    int[,] matrix = new int[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}
void PrintTwoDimensionalArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] CalculateSumOfline(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum[i] = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];
        }
    }
    return sum;
}

void PrintOneDimensionalArray(int[] matrix)
{
    for (int j = 0; j < matrix.Length; j++)
    {
        System.Console.Write($"{matrix[j]}\t");
    }
}

int FindMinIndex(int[] matrix)
{
    int minNumber = matrix[0];
    int index = 0;
    for (int i = 1; i < matrix.Length; i++)
    {
        if (matrix[i] < minNumber)
        {
            minNumber = matrix[i];
            index = i;
        }

    }
    return index;

}


int[,] matrix = FillArray(3, 5);
PrintTwoDimensionalArray(matrix);
System.Console.WriteLine();
int[] sum = CalculateSumOfline(matrix);
PrintOneDimensionalArray(sum);



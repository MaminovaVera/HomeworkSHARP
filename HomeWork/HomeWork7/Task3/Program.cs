// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}

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
void PrintArray(int[,] matrix)
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
void PrintArray2(double[] matrix)
{
    Console.WriteLine(" > ");
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            Console.Write($"{matrix[i]:f1}");
            if (i < (matrix.Length - 1))
            {
                Console.Write("\t");
            }
        };
        Console.WriteLine("");
    }
    
}
double[] FindMineOfColumns(int[,] matrix)
{
    double[] mineMatrix = new double[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            mineMatrix[i] += matrix[j, i];
        }
        mineMatrix[i] = mineMatrix[i] / matrix.GetLength(0);
    }
    return mineMatrix;
}
int[,] array = FillArray(Prompt("Введите число строк > "), Prompt("Введите число столбцов > "));
PrintArray(array);
double[] mineMatrix = FindMineOfColumns(array);
PrintArray2(mineMatrix);
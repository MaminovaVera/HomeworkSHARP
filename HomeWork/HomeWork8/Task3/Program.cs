// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MultiplyArrays(int[,] array1, int[,] array2)
{
    int[,] answer = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            answer[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                answer[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return answer;
}

void Main()
{
    int a = Prompt("Введите число строк первой матрицы >");
    int b = Prompt("Введите число столбцов первой матрицы >");
    int c = Prompt("Введите число строк второй матрицы >");
    int d = Prompt("Введите число столбцов второй матрицы >");
    if (!(a > 0 && b > 0 && c > 0 && d > 0))
    {
        System.Console.WriteLine("Невозможно решить задачу с такими условиями");
        return;
    }

    int[,] matrix1 = FillArray(a, b);
    int[,] matrix2 = FillArray(c, d);
    PrintArray(matrix1);
    System.Console.WriteLine();
    PrintArray(matrix2);
    System.Console.WriteLine();
    if (matrix1.GetLength(0) != matrix2.GetLength(1))
    {
        System.Console.WriteLine("Невозможно умножить матрицы ");
        return;
    }
    int[,] result = MultiplyArrays(matrix1, matrix2);
    PrintArray(result);
}
Main();
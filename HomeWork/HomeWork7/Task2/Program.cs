// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void ShowElement(int[,] matrix, int numLine, int numColumns)
{
    Console.Write($"{numLine}, {numColumns}> ");
    if (numLine > 0 && numLine < matrix.GetLength(0)
    && numColumns > 0 && numColumns < matrix.GetLength(1))
    {
        Console.WriteLine($"{matrix[numLine, numColumns]}");
    }
    else
    {
        Console.WriteLine("Такого элемента нет в массиве");
    }

}

int[,] array = FillArray(4,4);
PrintArray(array);
int numLine = Prompt("Введите число строк > ");
int numColumns = Prompt("Введите число столбцов > ");
ShowElement(array, numLine, numColumns);


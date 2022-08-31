// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[,] GenerateMassivOfRandomNumbers(int numLine, int numColumns)
{
    double[,] massivrandom = new double[numLine, numColumns];   // Создание нового массива
    for (int i = 0; i < massivrandom.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < massivrandom.GetLength(1); j++)     // Столбец
        {
            massivrandom[i, j] = (double)(new Random().Next(-100, 100)) / 10;      // Формула для заполнения массива
        }
    }
    return massivrandom;      // Возвращаем результат
}



void PrintArray(double[,] matrix)              // Функция печати массива 
{
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
        {
            Console.Write($"{matrix[i, j]}\t");     // Вывод значений очередной строки 
        }
        Console.WriteLine();    // Переход на следующую строку
    }
}

double[,] array = GenerateMassivOfRandomNumbers(Prompt("Введите число строк > "), Prompt("Введите число столбцов > "));
PrintArray(array);
System.Console.WriteLine();

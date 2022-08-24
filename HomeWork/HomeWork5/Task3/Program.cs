// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

double[] CreateArray(int length)
{
    double[] answer = new double[length];
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = new Random().Next(0, 10);
    }
    return answer;
}

void PrintArray(double[] array) // вывод массива на консоль
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}

double MaxElement(double[] array)
{
    double maxElement = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxElement)
        {
            maxElement = array[i];
        }
    }
    return maxElement;
}
double MinElement(double[] array)
{
    double minElement = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minElement)
        {
            minElement = array[i];
        }
    }
    return minElement;
}

double DifferenceBetweenMaxMin(double[] array)
{
    return MaxElement(array) - MinElement(array);
}

int sizeMassiv = Prompt("Введите размер массива >");
double[] newMassiv = CreateArray(sizeMassiv);
PrintArray(newMassiv);
System.Console.WriteLine(DifferenceBetweenMaxMin(newMassiv));
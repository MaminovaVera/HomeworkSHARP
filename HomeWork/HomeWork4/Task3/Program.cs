// Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран. 
// И ищет второй максимум (элемент меньше максимального, но больше всех остальных)

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int[] CreateArray(int length, int min, int max)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max);
    }
    return answer;
}
int SecondMax(int[] array)
{
    int max1 = array[0];
    int max2 = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max1)
        {
            max2 = max1;
            max1 = array[i];
        }
        if (array[i] > max2 && array[i] < max1)
        {
            max2 = array[i];
        }
    }
    return max2;
}
void PrintArray(int[] array) // вывод массива на консоль
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}

int lenght = Prompt($"Введите длину массива > ");
int min = Prompt($"Введите нижнюю границу диапозона >");
int max = Prompt($"Введите верхнюю границу диапозона >");
int [] set = CreateArray(lenght, min, max );
PrintArray(set);
System.Console.WriteLine($"Второй максимальный элемент массива {SecondMax(set)}");

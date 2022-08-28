// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int[] ArrayInput(int number)
{
    int[] array = new int[number];
    int i = 0;
    while (i < number)
    {
        System.Console.Write("Введите число >");
        array[i] = int.Parse(Console.ReadLine());
        i++;
    }
    return array;
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array) // вывод массива на консоль
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}
void CheckСonditions(int number)
{
    if (number > 0)
    {
        int[] array = ArrayInput(number);
        PrintArray(array);
        System.Console.WriteLine($"Количество чисел больше нуля равно {CountPositiveNumbers(array)}");
    }
    else
    {
        System.Console.WriteLine("Число не может быть отрицательным или равным нулю");
    }


}
int number = Prompt("Определите количество чисел для ввода ");
CheckСonditions(number);


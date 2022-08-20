// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}
int SumDigits(int number)
{
    int digit;
    int sum = 0;
    while (number > 0)
    {
        digit = number % 10;
        number = number / 10;
        sum = sum + digit;
    }
    return sum;
}
int number = Prompt($"Введите число   >");
System.Console.WriteLine($"Сумма цифр в числе равна {SumDigits(number)}");
SumDigits(number);


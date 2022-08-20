// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int Exponentiation(int numberA, int numberB)
{
    int res = 1;
    for (int i = 1; i <= numberB; i = i + 1)
    {
        res = res * numberA;
    }
    return res;
}
int numberA = Prompt($"Введите число A  >");
int numberB = Prompt($"Введите число B  >");
System.Console.WriteLine($"Число {numberA} возведенное в степень {numberB} равно {Exponentiation(numberA, numberB)}  ");
Exponentiation(numberA, numberB);

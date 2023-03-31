Console.Clear();
Console.WriteLine("Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А");
// Задача 24. Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А (4 -> (1+2+3+4) -> 10)
int num = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!", "Введите число больше 0. " );
int sumNumbers = GetSumNumbers(num);
Console.WriteLine($"{num} -> {sumNumbers}");
// Выводит в консоль сообщение message,
// преобразовывает введённую пользователем строку в число типа int.
// В случае ошибки выводит в консоль сообщение errorMessage
int GetNumberFromUser(string message, string errorMessage, string errorMessage1)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            if (userNumber < 1)
            {
                Console.Write(errorMessage1);
            }
            else
            {
                return userNumber;
            }
        Console.WriteLine(errorMessage);
    }
}
// Возвращает сумму чисел от 1 до number
int GetSumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number;
        number--;
    }
    return sum;
}


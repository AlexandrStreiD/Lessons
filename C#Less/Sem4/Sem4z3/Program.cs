Console.Clear();
Console.WriteLine("Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.");
int num = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int sumNumbers = GetPrNumbers(num);
Console.WriteLine($"{num} -> {sumNumbers}");
// Выводит в консоль сообщение message,
// преобразовывает введённую пользователем строку в число типа int.
// В случае ошибки выводит в консоль сообщение errorMessage
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
// Возвращает произведение чисел от 1 до number
int GetPrNumbers(int number)
{
    int proz = 1;
    while (number > 0)
    {
        proz = proz*number;
        number--;
    }
    return proz;
}


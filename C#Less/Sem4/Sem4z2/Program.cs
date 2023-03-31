Console.Clear();
Console.WriteLine("Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.");
int num = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!" );
int sumNumbers = GetSumNumbers(num);
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
        if (isCorrect && userNumber>0)         
            return userNumber;            
        Console.WriteLine(errorMessage);
    }
}
// Возвращает сумму чисел от 1 до number
int GetSumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {   
        number=number/10;
        sum ++;
    }
    return sum;
}


Console.Clear();
Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
int number = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int Sum = SumNumbers(number);
Console.WriteLine($"{number} -> {Sum}");
// Выводит в консоль сообщение message,
// преобразовывает введённую пользователем строку в число типа int.
// В случае ошибки выводит в консоль сообщение errorMessage
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
// Возвращает сумму чисел от 1 до number
int SumNumbers(int num)
{
    int i = 1;
    int sum = 0;
    if (num > 9)
    {
        while (num > 0)
        {   
            sum = sum + (num % 10);
            num=num/10;
        }
        
    }
    else sum=num;

    return sum;
}



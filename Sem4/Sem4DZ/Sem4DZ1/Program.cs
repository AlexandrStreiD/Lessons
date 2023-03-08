Console.Clear();
Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
int A = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!" );
int B = GetNumberFromUser("Введите целое число B: ", "Ошибка ввода!" );
int DegNumbers = NaturalDegree(A,B);
Console.WriteLine($"{A}, {B} -> {DegNumbers}");
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
int NaturalDegree(int A, int B)
{
    int Deg=1;
    for (int i = 1; i <= B; i++)
    {
        Deg=Deg*A;
    }

    return Deg;
}


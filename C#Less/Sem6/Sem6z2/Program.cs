//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

Console.Clear();
Console.WriteLine($"Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.");
int A = GetNumberFromUser("Введите первое число: ", "Ошибка ввода!");
int B = GetNumberFromUser("Введите второе число: ", "Ошибка ввода!");
int C = GetNumberFromUser("Введите третье число: ", "Ошибка ввода!");
// Каждая сторона треугольника должна быть меньше суммы двух других сторон
bool result = Result(A, B, C);
Console.WriteLine(result ? "ДА!" : "Нет!!!");

bool Result(int A, int B, int C)
{
    /*if (A < B + C && B < A + C && C < A + B)
    {
        return true;
    }
    else return false;
    */
    return (A < B + C && B < A + C && C < A + B);
}

//Console.Write($" -> {result}");

static int GetNumberFromUser(string message, string errorMessage)
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
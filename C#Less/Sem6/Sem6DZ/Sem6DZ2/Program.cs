//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
Console.Clear();
Console.WriteLine($"Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; \nзначения b1, k1, b2 и k2 задаются пользователем.");
double b1 = GetNumberFromUser1("Введите b1: ", "Ошибка ввода!");
double k1 = GetNumberFromUser1("Введите k1: ", "Ошибка ввода!");
double b2 = GetNumberFromUser1("Введите b2: ", "Ошибка ввода!");
double k2 = GetNumberFromUser1("Введите k2: ", "Ошибка ввода!");
double X = FindX(b1, k1, b2, k2);
double Y = FindY(b1, k1, X);
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} --> Пересечение в точке:({X};{Y})");


static int GetNumberFromUser1(string message, string errorMessage)
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


double FindX(double b1, double k1, double b2, double k2)
{
    double x = -(b1 - b2) / (k1 - k2);
    return x;

}

double FindY(double b1, double k1, double x)
{
    double y = k1 * x + b1;
    return y;
}



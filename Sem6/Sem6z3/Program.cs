//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.Clear();
Console.WriteLine($"Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.");
int num = GetNumberFromUser("Введите число: ", "Ошибка ввода!");
// Каждая сторона треугольника должна быть меньше суммы двух других сторон
int[] result = GetDecToBin(num);
//Console.WriteLine($"{num} -> {result}");
Console.Write($"{num} --> {string.Join("", result)}");


int[] GetDecToBin(int a)
{
    int temp = a;
    int count = 0;
    while (temp > 0)
    {
        temp /= 2;
        count++;
    }
    int[] result = new int[count];
    for (int i = count - 1; i >= 0; i--)
    {
        result[i] = a % 2;
        a /= 2;
    }
    return result;
    //result=0;

}


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
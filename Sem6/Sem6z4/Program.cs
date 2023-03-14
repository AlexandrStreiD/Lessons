//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Console.Clear();
Console.WriteLine($"Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.");
int num = GetNumberFromUser("Введите число: ", "Ошибка ввода!");
int[] result = Fibanachi(num);
Console.Write($"{num} --> {string.Join(" ", result)}");


int[] Fibanachi(int a)
{

    if (a==1){
        return new int[1];
    }
    int[] result = new int[a];
    result[0]=0;
    result[1]=1;
    for (int i = 2; i < result.Length; i++)
    {
        result[i] =  result[i-1]+ result[i-2];
    
    }
    return result;
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
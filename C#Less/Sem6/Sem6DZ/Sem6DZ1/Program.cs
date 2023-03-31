//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
Console.WriteLine($"Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
int num = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int[] array = GetArray(num);
int result = GetSumm(array);
Console.Write($"[{String.Join(", ", array)}] --> {result}");



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


int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = GetNumberFromUser1($"Введите {i} элемент массива: ", "Ошибка ввода!");
    }
    return res;
}

int GetSumm(int[] arr)
{
    int summ=0;
    for (int i=0; i<arr.Length; i++){
        if(arr[i]>0){
            summ++;
        }
    }
    return summ;
}



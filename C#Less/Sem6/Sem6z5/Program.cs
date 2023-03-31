//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
Console.Clear();
Console.WriteLine($"Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.");
int num = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int[] array = GetArray(num);
int[] copyArray = GetCopyArray(array);
Console.Write($"[{String.Join(", ", array)}]");
Console.Write($"[{String.Join(", ", copyArray)}]");


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

int[] GetCopyArray(int[] arr){
    int[] copyArr = new int[arr.Length];
    for (int i=0; i<arr.Length; i++){
        copyArr[i]=arr[i];
    }
    return copyArr;
}



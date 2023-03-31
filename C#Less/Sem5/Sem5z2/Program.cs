Console.Clear();
Console.WriteLine($"Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.");
int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));

int[] array1 = GetInversion(array);
Console.WriteLine(String.Join(" ", array1));
//Console.WriteLine($"Positive sum = {positiveSum}, negative sum = {negativeSum} ");
//////////////////////////////////////////////////////////////////////////////////
// Возвращает массив из size элементов,
// заполненный случайными числами из промежутка [minValue, maxValue]
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] GetInversion(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]=arr[i]*(-1);
    }
    return arr;
}

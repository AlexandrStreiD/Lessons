//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой находится эта точка.
// -------------------------- Начало программы ----------------------------------
Console.Clear();
Console.WriteLine("Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
int[] A  = new int [3];
int[] B  = new int [3];

A [0] = ReadNumber("Введите координату Х точки А ");
A [1] = ReadNumber("Введите координату Y точки А ");
A [2] = ReadNumber("Введите координату Z точки А ");
B [0] = ReadNumber("Введите координату Х точки B ");
B [1] = ReadNumber("Введите координату Y точки B ");
B [2] = ReadNumber("Введите координату Z точки B ");
Console.WriteLine($"Расстояние между точками A({A[0]},{A[1]},{A[2]}) и B({B[0]},{B[1]},{B[2]}) {Result(A [0], A [1], A [2], B [0], B [1], B [2])}" ) ;


static int ReadNumber(string message)
{
    int n = 0;
    while (true)
    {
        try
        {
            Console.WriteLine(message);
            n = int.Parse(Console.ReadLine() ?? "");  
            break;          
        }
        catch (Exception exc)
        {
            Console.WriteLine("Ошибка ввода! Введите число!");
        }
    }
    return n;
}

static double Result(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double ress = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
    return ress;
}




//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой находится эта точка.
// -------------------------- Начало программы ----------------------------------
Console.Clear();
Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.");
int[] A  = new int [2];
int[] B  = new int [2];

A [0] = ReadNumber("Введите координату Х точки А ");
A [1] = ReadNumber("Введите координату Y точки А ");
B [0] = ReadNumber("Введите координату Х точки B ");
B [1] = ReadNumber("Введите координату Y точки B ");
Console.WriteLine($"Расстояние между точками A({A[0]},{A[1]}) и B({B[0]},{B[1]}) {Result(A [0], A [1], B [0], B [1])}" ) ;

//PrintResult(num);
//Console.WriteLine("корень квадратный из суммы квадратов разностей координат");
//Console.WriteLine("AB = √ (x b - x a) 2 + (y b - y a) Math.sqrt");

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

static double Result(int x1, int y1, int x2, int y2)
{
    double ress = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
    return ress;
}




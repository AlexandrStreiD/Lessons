// See https://aka.ms/new-console-template for more information


Console.Write("Введите целое число: ");
string Chislo = Console.ReadLine() ?? "";
int Chint = int.Parse(Chislo);
//int Chint = int.Parse(Console.ReadLine() ?? "");
int result = (int)Math.Pow(Chint, 2);
Chint=Chint*Chint;
Console.WriteLine($"Квадрат {Chislo} равен: {Chint}");
Console.WriteLine("Квадрат введенного "+Chislo+" равен: "+Chint);
Console.Write("Квадрат введенного "+Chislo+" равен: "+result);
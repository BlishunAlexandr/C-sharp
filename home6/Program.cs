// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите число или введите stop для завершения: ");
string Num1 = Console.ReadLine() ?? "";
int Result = 0;
while (Num1.ToLower() != "stop")
{
    if (int.TryParse(Num1, out int num) && num > 0)
    {

        Result++;
    }
    Console.Write("Введите число или введите stop для завершения: ");
    Num1 = Console.ReadLine() ?? "";
}
Console.WriteLine($"Результат: {Result}");



//
Console.WriteLine("Введите значение k1:");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение b1:");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение k2:");
double k2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение b2:");
double b2 = double.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine("Точка пересечения двух прямых: ({0}, {1})", x, y);
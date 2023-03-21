// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] RandomArrayInt(int quantity, int start, int stop)
{
    int[] Array = new int[quantity];
    for (int i = 0; i < quantity; i++)
    {
        Array[i] = new Random().Next(start, stop);
    }
    return Array;
}

void PrintArrayInt(int[] Array)
{
    for(int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine();
}

int Function1(int[] Array)
{
    int result = 0;
    for(int i = 0; i < Array.Length; i++)
    {
        if((Array[i] % 2) == 0) result++;
    }
    return result;
}

int[] Array1 = RandomArrayInt(3, 100, 1000);
int Num1 = Function1(Array1);
Console.Write("Задание 1, список: ");
PrintArrayInt(Array1);
Console.WriteLine($"Количество четных чисел: {Num1}");
Console.WriteLine();




// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int Function2(int[] Array)
{
    int result = 0;
    for(int i = 0; i < Array.Length; i += 2)
    {
        result = result + Array[i];
    }
    return result;
}

int[] Array2 = RandomArrayInt(5, 1, 10000);
int Num2 = Function2(Array2);
Console.Write("Задание 2, список: ");
PrintArrayInt(Array2);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях {Num2}");
Console.WriteLine();




// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void PrintArrayDouble(double[] Array)
{
    for(int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine();
}

double[] RandomArrayDouble(int quantity, double stop)
{
    double[] Array = new double[quantity];
    for (int i = 0; i < quantity; i++)
    {
        Array[i] = new Random().NextDouble() * stop;
    }
    return Array;
}

double Function3(double[] Array)
{
    double max = Array[0];
    double min = Array[0];
    for(int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > max) max = Array[i];
        else if (Array[i] < min) min = Array[i];
    }
    double result = max - min;
    return result;
}


double[] Array3 = RandomArrayDouble(3, 10);
double Num3 = Function3(Array3);
Console.Write("Задание 3, список: ");
PrintArrayDouble(Array3);
Console.WriteLine($"Разница : {Num3}");
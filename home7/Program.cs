// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void PrintArrayDouble(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]}; ");
        }
        Console.WriteLine();
    }
}

double[,] FunctionNum1(int m, int n, int max)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * max;
        }
    }
    return result;
}

Console.WriteLine("ЗАДАНИЕ 1: ");
double[,] Num1 = FunctionNum1(4, 8, 100);
PrintArrayDouble(Num1);
Console.WriteLine();



// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] CreateRandomArray(int m, int n, int start, int stop)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(start, stop + 1);
        }
    }
    return result;
}

void PrintArrayInt(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]}; ");
        }
        Console.WriteLine();
    }
}

void FunctionNum2(int search, int[,] Array)
{
    bool found = false;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if(Array[i, j] == search) 
            {
                Console.WriteLine($"Строка: {i+1}, столбец: {j+1};");
                if(found == false) found = true;
            }
        }
    }
    if(found == false) Console.WriteLine($"Числа {search} нету");
}

Console.WriteLine("ЗАДАНИЕ 2: ");
int[,] Array2 = CreateRandomArray(3, 3, 0, 10);
PrintArrayInt(Array2);
FunctionNum2(5, Array2);
Console.WriteLine();


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void FucntionNum3(int[,] Array) 
{
    double[] result = new double[Array.GetLength(1)]; // создал массив который хранит кол-во столбцов что бы в будущем в него положить результаты
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        int temporarily = 0;
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            temporarily = temporarily + Array[j, i];
            result[i] = temporarily;
            if(j == Array.GetLength(1) - 1) 
            {
                result[i] = result[i] / Array.GetLength(1);
                Console.WriteLine($"{i+1}й столбец: {result[i]}");
            }
        }
    }
}

Console.WriteLine("ЗАДАНИЕ 3: ");
int[,] Array3 = CreateRandomArray(3, 3, 0, 10);
PrintArrayInt(Array3);
FucntionNum3(Array3);
Console.WriteLine();

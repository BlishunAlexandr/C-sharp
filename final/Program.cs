// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
int n = 15;
int m = 1; // в следующих заданиях нужно будет
string Recursion(int number) 
{
   if (number == 1) return number.ToString();
   
   return number + " " + Recursion(number - 1);
}

Console.Write(Recursion(n));




// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int Sum(int M, int N)
{
    if (M > N)
    {
        int temp = M;
        M = N;
        N = temp;
    }
    int result = N;
    if (M < N)
    {
        result += Sum(M, N-1);
    }
    return result;
}

Console.WriteLine();
int Num2 = Sum(m, n);
Console.WriteLine(Num2);



// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Write("Введите число M: "); 
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return (Ackermann(m - 1, Ackermann(m, n - 1)));
    }
}

int Num3 = Ackermann(m, n);
Console.WriteLine(Num3);
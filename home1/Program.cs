// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int First = new Random().Next(0, 11);
int Second = new Random().Next(0, 11); 

if(First == Second)
{
    Console.WriteLine("Они одинаковые");
}
else if(First > Second) 
{
    Console.WriteLine($"{First} больше чем {Second}");
    Console.WriteLine("Второче число больше");
}
else
{
    Console.WriteLine($"{Second} больше чем {First}");
    Console.WriteLine("Второче число больше");
}


Console.Write("Введите любой текст для продолжения: "); // для проверки задачи 
Console.ReadLine();



// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int Third = new Random().Next(0, 11); // две первые переменные уже есть
Console.WriteLine($"3е число : {Third}"); 
int max = First;

if (max < Second) max = Second;
if (max < Third) max = Third;

Console.WriteLine($"Максимальное число {max}");


Console.Write("Введите любой текст для продолжения: "); 
Console.ReadLine();



// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
if(First == 0)
{
    Console.WriteLine("0 не подходит");
}
else if((First % 2) == 0) // буду работать с существующей переменной
{
    Console.WriteLine($"{First} четное");
}
else
{
    Console.WriteLine($"{First} нечетное");
}



Console.Write("Введите любой текст для продолжения: "); 
Console.ReadLine();



//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int i = 1;
if(First != 0) // проверка на 0, так же буду исчпользовать уже существующую переменную 
{
    while(i < (First + 1)) // + 1 для того что бы было включительно
    {
        if((i % 2) == 0) Console.Write($"{i} "); // $ для пробелов между числами
        i = i + 1;
    }
}
else
{
    Console.WriteLine("0 не подходит");
}
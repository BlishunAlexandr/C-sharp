// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int First = new Random().Next(100, 1000);

int OneA = First / 10; // получаю двухзначное целое число 
int OneB = OneA % 10; // остаток от двухзначного числа и есть второе число 
Console.WriteLine($"Второе число числа {First} это {OneB}");

Console.Write("Введите любой текст для продолжения: ");
Console.ReadLine();



// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int Second = new Random().Next(10, 1000);
int TwoB = Second % 10;
int CheckSecond = Second / 100;
if (CheckSecond != 0)
{
    Console.WriteLine($"Последнее число из числа {Second} это {TwoB}");
}
else
{
    Console.WriteLine($"Число {Second} двухзначное");
}

Console.Write("Введите любой текст для продолжения: ");
Console.ReadLine();



//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int Day;
while(true)
{
    Console.Write("Введите день недели (Цифру): ");
    Day = int.Parse(Console.ReadLine() ?? "");
    if (Day >= 1 && Day <= 5)
    {
        Console.WriteLine("Будний день");
        break;
    }
    else if (Day == 6 || Day == 7) // хочу использовать разные логические операторы 
    {
        Console.WriteLine("Выходной день");
        break;
    }
    else
    {
        Console.WriteLine("Неправильно число");
    }
}
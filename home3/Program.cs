// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int i = 0;
int two = 0;
int One = 12321;
int OneCheck = One;
while(i < 5)
{
    two = (two * 10) + (One % 10);
    One = One / 10;
    i++;
}

if (OneCheck == two)
{
    Console.WriteLine($"число {OneCheck} является палиндромом");
}
else
{
    Console.WriteLine($"число {OneCheck} не является палиндромом");
}



//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
 Console.Write("Какое кол-во раз надо возвести число в куб: ");
int Check = int.Parse(Console.ReadLine() ?? "");
i = 0;
int Num = 1;
while (i < Check) {
    Console.WriteLine($"{Num} ** 3 = {Math.Pow(Num, 3)}");
    i++;
    Num++;
}

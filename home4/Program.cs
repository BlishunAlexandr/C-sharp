// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int A = 3; 
int A_clone = A;
int B = 5;
int i = 1;

while(i < B)
{
    A = A * A_clone;
    i++;
}

Console.WriteLine($"Итог : {A}");



//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Num = 5433435;
int Result = 0;
while(true)
{
    int Num_A = Num % 10;
    Num = Num / 10;
    Result = Result + Num_A;
    if(Num % 10 == 0) break;
}
Console.WriteLine($"Получается {Result}");




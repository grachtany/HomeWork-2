// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int numberA = new Random().Next (100, 1000)  ;
Console.WriteLine($"Случайное число {numberA}");
int result = (numberA/10)%10;
Console.WriteLine ($"Вторая цифра числа {numberA} - {result}");

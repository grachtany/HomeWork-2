// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите номер дня недели - ");
int number1 = int.Parse(Console.ReadLine());
if (1<=number1 && number1<=5 ) 
    Console.WriteLine ($"День недели под номером {number1} - будний день");
    else 
        Console.WriteLine ($"День недели под номером {number1} - выходной день");
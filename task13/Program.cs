// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.Clear();
Console.Write("Введите число a - ");

string mas = Console.ReadLine();

int n = mas.Length;
int index = 0;

if (n>2)
    Console.WriteLine ($"Третья цифра заданного числа {mas[2]}");
else 
    Console.WriteLine ($"Третья цифра заданного числа отсутствует");

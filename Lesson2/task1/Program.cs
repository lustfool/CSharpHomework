// Задача 1: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

Console.Write("Введите трёхзначное число: ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);

if (paramString.Length != 3) Console.WriteLine("Введено неверное число!");
else Console.Write("Вторая цифра числа - " + (paramInt % 100)/10);
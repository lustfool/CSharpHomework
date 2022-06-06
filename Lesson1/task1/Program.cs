//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число => ");
string paramStringFirst = Console.ReadLine();
int paramIntFirst = int.Parse(paramStringFirst);
Console.Write("Введите второе число => ");
string paramStringSecond = Console.ReadLine();
int paramIntSecond = int.Parse(paramStringSecond);

if (paramIntFirst > paramIntSecond)
{
    Console.Write($"Большее число =  {paramIntFirst}, меньшее число = {paramIntSecond}");
}
else
{
    Console.Write($"Большее число =  {paramIntSecond}, меньшее число = {paramIntFirst}");
}
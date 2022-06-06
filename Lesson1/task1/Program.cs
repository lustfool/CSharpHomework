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
if (paramIntSecond > paramIntFirst)
{
    Console.Write($"Большее число =  {paramIntSecond}, меньшее число = {paramIntFirst}");
}
else
{
    Console.Write("Числа равны");  //раньше было только одно условие и else, но пришлось добавить второе на случай равенства введённых чисел
}
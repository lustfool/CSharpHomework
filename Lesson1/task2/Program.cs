//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число => ");
string paramStringFirst = Console.ReadLine();
int paramIntFirst = int.Parse(paramStringFirst);
Console.Write("Введите второе число => ");
string paramStringSecond = Console.ReadLine();
int paramIntSecond = int.Parse(paramStringSecond);
Console.Write("Введите третье число => ");
string paramStringThird = Console.ReadLine();
int paramIntThird = int.Parse(paramStringThird);

int max = paramIntFirst;
if (paramIntSecond >= max) //больше или равно указано для того случая, когда среди введённых есть два одинаковых числа
{
    max = paramIntSecond; 
}
if (paramIntThird >= max)
{
    max = paramIntThird;
}
Console.Write($"Максимальное из этих чисел {max}");
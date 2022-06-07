//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число => ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);

int n = 1;
Console.Write("Чётные числа: ");
while (n <= paramInt)
{
    if (n % 2 == 0)
    {
        Console.Write($"{n}, ");
    }
    n = n + 1;
}
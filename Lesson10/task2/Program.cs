// Задача 2: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m < 0 || n < 0)
    {
        Console.WriteLine("Функция Аккермана принимает на вход только неотрицательные числа");
        Environment.Exit(0);
    }
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = Prompt("Введите 1й параметр => ");
int n = Prompt("Введите 2й параметр => ");
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");
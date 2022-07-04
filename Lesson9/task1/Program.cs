// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintOddNaturalNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
    {
        return;
    }
    if (firstNumber % 2 == 0)
        Console.Write($"{firstNumber}; ");
    PrintOddNaturalNumbers(firstNumber + 1, secondNumber);
}

int M = Prompt($"Введите 1е число => ");
int N = Prompt($"Введите 2е число => ");
Console.WriteLine($"Чётные натуральные числа в промежутке от {M} до {N}:");
PrintOddNaturalNumbers(M, N);
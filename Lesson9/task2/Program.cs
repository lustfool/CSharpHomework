// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int PrintEvenNaturalNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
    {
        return 0;
    }
    return PrintEvenNaturalNumbers(firstNumber + 1, secondNumber) + firstNumber;
}

int M = Prompt($"Введите 1е число => ");
int N = Prompt($"Введите 2е число => ");
Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N}: {PrintEvenNaturalNumbers(M, N)}");

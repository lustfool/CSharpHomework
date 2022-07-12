// // Задача 1: Есть монотонная последовательность, 
// каждое число встречается ровно то количество раз, 
// какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... 
// Выведите ряд этой 
// последовательности до N-го значения, желательно использовать рекурсию:

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}


void PrintTriangleSequence(int n, int k = 1)
{
    int count = (k + 1) * k / 2;
    for (int i = count - k; i < count && i < n; i++)
        Console.Write($"{k}, ");
    if (count < n) PrintTriangleSequence(n, k + 1);
}


int n = Prompt("Введите количество элементов последовательности => ");
PrintTriangleSequence(n);
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.


int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int N = Prompt("Введите число: ");

int i = 0;

while (i < N)
{
    i++;
    System.Console.WriteLine($"Куб числа {i} = {i * i * i}");
}
//Задача 2. Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * 
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
// пользователем.

int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    return int.Parse(number);
}

string PointOfCollision(double b1, double k1, double b2, double k2)
{
    var x = (b2 - b1) / (k1 - k2);
    if (k1 - k2 == 0) 
    {
        System.Console.WriteLine("Линии параллельны.");
        Environment.Exit(0);
    }
    var y = k2 * x + b2;
    string result = $"({x}; {y})";
    return result;
}

Console.WriteLine("Уравнения прямых y = k1 * x + b1, y = k2 * x + b2");
int b1 = Prompt("Введите значение b1 => ");
int k1 = Prompt("Введите значение k1 => ");
int b2 = Prompt("Введите значение b2 => ");
int k2 = Prompt("Введите значение k2 => ");
Console.WriteLine($"Точка пересечения прямых {PointOfCollision(b1, k1, b2, k2)}");

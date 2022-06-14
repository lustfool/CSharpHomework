// Задача 2: Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int x1 = Prompt("Введите координату x1: ");
int y1 = Prompt("Введите координату y1: ");
int z1 = Prompt("Введите координату z1: ");
int x2 = Prompt("Введите координату x2: ");
int y2 = Prompt("Введите координату y2: ");
int z2 = Prompt("Введите координату z2: ");

double function(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)));
    return result;
}

System.Console.WriteLine($"Расстояние между точками {(x1, y1, z1)} и {(x2, y2, z2)} = {function(x1, y1, z1, x2, y2, z2)}");
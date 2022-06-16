// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    return int.Parse(number);
}

int Stepen(int osn, int step)
{
    int answer = 1;
    for (int i = 0; i < step; i++)
    {
        answer = answer * osn;
    }
    return answer;
}

int basis = Prompt("Введите основание = ");
int degree = Prompt("Введите степень = ");
Console.Write($"Результат = {Stepen(basis, degree)}");
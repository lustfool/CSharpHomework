// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    return int.Parse(number);
}

int SummDigits(int number)
{
    int summa = 0;
    string str = number.ToString();
    for (int i = 0; i < str.Length; i++)
    {
        summa = summa + number % 10;
        number = number / 10;
    }
    return summa;
}

int num = Prompt("Введите число => ");
Console.WriteLine("Сумма цифр в числе = " + SummDigits(num));
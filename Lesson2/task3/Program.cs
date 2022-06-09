// Задача 3: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры
// нет.

// Console.Write("Введите число: ");
// string number = Console.ReadLine();
// if (number.Length < 3) Console.WriteLine("Третьей цифры нет");
// else Console.WriteLine("Третья цифра числа: " + number[2]);

int prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}
int numberInt = prompt("Введите число ");
if (numberInt < 100) Console.WriteLine("Третьей цифры нет");
else
{
    while (numberInt > 999)
    {
        numberInt = numberInt / 10;
    }
    numberInt = numberInt % 100;
    numberInt = numberInt % 10;
    Console.WriteLine("Третья цифра числа: " + numberInt);
}

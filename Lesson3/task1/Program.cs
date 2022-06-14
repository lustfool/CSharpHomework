// Задача 1: Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int number = Prompt("Введите пятизначное число: ");

int i1 = number / 10000;
int i2 = (number % 10000) / 1000;
int i4 = (number % 100) / 10;
int i5 = number % 10;


if (i1 == i5 && i2 == i4) System.Console.WriteLine("Число являяется палиндромом");
else System.Console.WriteLine("Число не является палиндромом");
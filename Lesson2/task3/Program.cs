// Задача 3: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры
// нет.

Console.Write("Введите число: ");
string number = Console.ReadLine();
if (number.Length < 3) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine("Третья цифра числа: " + number[2]);

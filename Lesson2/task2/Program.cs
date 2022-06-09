// Задача 2: Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру
// этого числа.

int number = new Random().Next(100, 1000);
Console.WriteLine("Случайное трёхзначное число: " + number);

int[] array = new int[3];

array[0] = number / 100;
array[1] = (number % 100) / 10;
array[2] = number % 10;

Console.WriteLine("Получившееся число без второй цифры: " + array[0]+array[2]);
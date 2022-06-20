//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] InitArray(int len)
{
    Random rnd = new Random();
    int[] arrA = new int[len];
    for (var i = 0; i < len; i++)
    {
        arrA[i] = rnd.Next(100, 1000);
    }
    return arrA;
}

void PrintArray(int[] arrA)
{
    foreach (int element in arrA)
    {
        System.Console.Write($" {element}; ");
    }
    System.Console.WriteLine();
}

int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

int EvenNumbers (int[]array)
{
    int result = 0;
     foreach (int element in array)
    {
        if (element % 2 == 0) result += 1;
    }
    return result;
}

int[] myArray = InitArray(Prompt("Введите размер массива: "));
PrintArray(myArray);
System.Console.WriteLine($"Количество чётных чисел равно = {EvenNumbers(myArray)}");
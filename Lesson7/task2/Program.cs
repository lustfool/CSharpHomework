//Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

string FindArrayElement(int[,] array, int rowPossition, int columnPossition)
{
    string result = "";
    if (rowPossition>array.GetLength(0) || columnPossition>array.GetLength(1)) 
    {
        result = $"На введенной позиции ({rowPossition}; {columnPossition}) элемента нет.";
    }
    else
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == array[rowPossition-1, columnPossition-1]) 
            {
            result = $"На введенной позиции ({rowPossition}; {columnPossition}) находится элемент {array[i,j]}.";
            }
        }
    }
    return result;
}

int row = Prompt("Введите количество строк => ");
int column = Prompt("Введите количество столбцов => ");
int min = 0;
int max = 10;
int[,] myArray = GenerateArray(row, column, min, max);
PrintArray(myArray);
int rowPossition = Prompt ("Введите номер строки => ");
int columnPossition = Prompt ("Введите номер столбца => ");
Console.WriteLine(FindArrayElement(myArray, rowPossition, columnPossition));
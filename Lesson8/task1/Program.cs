// Задача 1: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.


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

void Print2DArray(int[,] array)
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

void SortingInRowsFromMaxToMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int max = j;
            for (int k = j; k < array.GetLength(1); k++)
            {
                if (array[i, max] < array[i, k])
                {
                    max = k;
                }
            }
            int temp = array[i, max];
            array[i, max] = array[i, j];
            array[i, j] = temp;
        }
    }
}

int row = Prompt("Введите количество строк => ");
int column = Prompt("Введите количество столбцов => ");
int min = 0;
int max = 10;
int[,] myArray = GenerateArray(row, column, min, max);
Print2DArray(myArray);
SortingInRowsFromMaxToMin(myArray);
Console.WriteLine("Матрица с упорядоченными по убыванию элементами в строках: ");
Print2DArray(myArray);
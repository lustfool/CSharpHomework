//Задача 3: Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.


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

void PrintArray(double[] array)
{
    foreach (double element in array) Console.Write($"{element:F1}; ");
    Console.WriteLine();
}

double[] FindAverageOfColumn(int[,] array)
{
    double temp = 0;
    double[] averageArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++) temp = temp + array[i, j];
        averageArray[j] = temp / array.GetLength(0);
        temp = 0;
    }
    return averageArray;
}

int row = Prompt("Введите количество строк => ");
int column = Prompt("Введите количество столбцов => ");
int min = 0;
int max = 10;
int[,] myArray = GenerateArray(row, column, min, max);
Print2DArray(myArray);
double[] averageArray = FindAverageOfColumn(myArray);
Console.WriteLine("Среднее арифметическое каждого столбца:");
PrintArray(averageArray);
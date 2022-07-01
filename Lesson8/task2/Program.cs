// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

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

int FindLowestSummInARow(int[,] array)
{
    int[] sumInRowArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumInRowArray[i] = sumInRowArray[i] + array[i, j];
        }
    }
    int minimumSum = sumInRowArray[0];
    int minimumRow = 1;
    for (int k = 1; k < sumInRowArray.Length; k++)
        if (sumInRowArray[k] < minimumSum)
        {
            minimumSum = sumInRowArray[k];
            minimumRow = k + 1;
        }
    return minimumRow;
}

int row = Prompt("Введите количество строк => ");
int column = Prompt("Введите количество столбцов => ");
int min = 0;
int max = 10;
int[,] myArray = GenerateArray(row, column, min, max);
Print2DArray(myArray);
System.Console.WriteLine($"Строка с наименьшей суммой элементов => {FindLowestSummInARow(myArray)}");
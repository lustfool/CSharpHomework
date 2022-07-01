//Задача 3: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

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

void CompositionPossibility (int columnFirst, int rawSecond)
{
    if (columnFirst != rawSecond)
    {
        Console.WriteLine("Такие матрицы перемножать нельзя! Число столбцов 1й матрицы должно быть равно числу строк второй.");
        Environment.Exit(0);
    }
}

int [,] CompositionOfTwoMatrix (int[,] firstMatrix, int[,] secondMatrix)
{
    int [,] compositionMatrix = new int [firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < compositionMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < compositionMatrix.GetLength(1); j++)
        {
            for (int k = 0; k <= compositionMatrix.GetLength(1); k++)
            {
                compositionMatrix [i,j] = compositionMatrix [i,j] + firstMatrix [i,k]*secondMatrix[k,j];
            }
        }
    }
    return compositionMatrix;
}

int rowFirst = Prompt("Введите количество строк 1й матрицы => ");
int columnFirst = Prompt("Введите количество столбцов 1й матрицы => ");
int rowSecond = Prompt("Введите количество сторок 2й матрицы => ");
int columnSecond = Prompt("Введите количество столбцов 2й матрицы => ");
int min = 0;
int max = 10;
CompositionPossibility(columnFirst, rowSecond);
int[,] myFirstMatrix = GenerateArray(rowFirst, columnFirst, min, max);
int[,] mySecondMatrix = GenerateArray(rowSecond, columnSecond, min, max);
Console.WriteLine("1я матрица: ");
Print2DArray(myFirstMatrix);
Console.WriteLine("2я матрица: ");
Print2DArray(mySecondMatrix);
int [,] compositionMatrix = CompositionOfTwoMatrix (myFirstMatrix, mySecondMatrix);
Console.WriteLine("Произведение двух матриц: ");
Print2DArray(compositionMatrix);
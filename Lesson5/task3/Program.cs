//Задача 3: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double[] InitArray(int leng)
{
    Random rnd = new Random();
    double[] array = new double[leng];
    for (int i = 0; i < leng; i++) array[i] = rnd.NextDouble() * 100;
    return array;
}

void PrintArray(double[] arrA)
{
    foreach (double element in arrA) Console.Write($"{element:F3}; ");
    Console.WriteLine();
}

int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

double DiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return max-min;
}

double[] myArray = InitArray(Prompt("Введите размер массива: "));
double differ = DiffMaxMin(myArray);
PrintArray(myArray);
System.Console.WriteLine($"Разница между максимальным значением и минимальным = {differ:F3}");
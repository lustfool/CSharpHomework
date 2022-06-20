//Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] InitArray(int len, int min, int max)
{
    Random rnd = new Random();
    int[] arrA = new int[len];
    for (var i = 0; i < len; i++)
    {
        arrA[i] = rnd.Next(min, max + 1);
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

int SumUnevenElements(int[] array)
{
    int summa = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        summa = summa + array[i];
    }
    return summa;
}

int[] myArray = InitArray(Prompt("Введите размер массива: "), Prompt("Введите нижнюю границу случайных чисел: "), Prompt("Введите верхнюю границу случайных чисел: "));
PrintArray(myArray);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна {SumUnevenElements(myArray)}");
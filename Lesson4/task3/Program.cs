// Задача 3: Напишите программу, которая задаёт массив из
// 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции 
// (пригодится в следующих задачах)

int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    return int.Parse(number);
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + "; ");
    }
    System.Console.WriteLine();
}

int[] RandomizeArray(int Length)
{
    int[] array = new int[Length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2001);
    }
    return array;
}

int size = Prompt("Введите размер массива => ");
int[] myarray = RandomizeArray(size);
PrintArray(myarray);
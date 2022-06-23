//Задача 1: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    var num = int.Parse(number);
    return num;
}

void PrintArray(int[] array)
{
    foreach (var e in array) Console.Write(e + " ");
    System.Console.WriteLine();
}

int[] FillArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = Prompt($"Введите {i + 1}е число => ");
    }
    return array;
}

int PositiveNumbers(int[] array)
{
    int result = 0;
    for (int i =0; i < array.Length; i++)
    if (array[i] > 0) result++;
    return result;
}

int number = Prompt("Введите КОЛИЧЕСТВО вводимых чисел => ");
int[] myArr = FillArray(number);
Console.Write("Введённые числа: ");
PrintArray(myArr);
System.Console.WriteLine($"Количество чисел БОЛЬШЕ 0 равно {PositiveNumbers(myArr)}");
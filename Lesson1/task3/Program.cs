//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число => ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);

if(paramInt % 2 == 0)
{
    Console.Write($"Число {paramInt} является чётным.");
}
else
{
    Console.Write($"Число {paramInt} является нечётным.");
}
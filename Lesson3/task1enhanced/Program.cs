// Задача 1 усложнённая: Напишите программу, которая принимает на вход ЛЮБОЕ 
// число и проверяет, является ли оно палиндромом.

Console.Write("Введите число => ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);

int ln = paramString.Length - 1;
int iFirst = 0;
int iLast = 0;

while (ln >= 1)
{
    iFirst = paramInt / Convert.ToInt32(Math.Pow(10, ln));
    iLast = paramInt % 10;
    if (iFirst == iLast)
    {
        paramInt = (paramInt % Convert.ToInt32(Math.Pow(10, ln))) / 10;
        ln = ln - 2;
    }
    else
    {
        System.Console.WriteLine("Число не является палиндромом");
        Environment.Exit(0);
    }
}
System.Console.WriteLine("Число является палиндромом");
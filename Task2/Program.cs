// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int PromptInt(string strMessage) // Ввод целого числа с выводом сопроводительного сообщения
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

bool IsNegative(int N)
{
    if (N < 0) return true;
    return false;
}

void SumOfDigits(int intN)
{
    System.Console.Write($"Cумма цифр числа {intN} равна ");
    if (IsNegative(intN)) intN *= -1;
    int result = 0;
    while (intN > 0)
    {
        result += intN % 10;
        intN /= 10;
    }
    System.Console.WriteLine(result);
}

System.Console.WriteLine("Данная программа принимает принимает на вход число и выдаёт сумму цифр в числе.");
int intN = PromptInt("Введите положительное целое число: ");
SumOfDigits(intN);

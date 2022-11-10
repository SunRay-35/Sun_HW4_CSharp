// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int PromptInt(string strMessage) // Ввод целого числа с выводом сопроводительного сообщения
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

bool IsEven(int N)
{
    if (N % 2 == 0) return true;
    return false;
}

bool IsNegative(int N)
{
    if (N < 0) return true;
    return false;
}

int CustomPower(int intBase, int intPower)
{
    if (intPower == 0) return 1; // Частный случай для степени 0
    if (IsNegative(intPower)) intPower *= -1;
    if (IsEven(intPower))
    {
        int Result = CustomPower(intBase, intPower/2);
        return Result * Result;
    }
    else return intBase * CustomPower(intBase, intPower-1);
}


System.Console.WriteLine("Данная программа принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
int intA = PromptInt("Введите целое число A: ");
int intB = PromptInt("Введите целое число B: ");
if (IsNegative(intB)) System.Console.Write("Степень равна: 1/");
else System.Console.Write("Степень равна: ");
System.Console.WriteLine(CustomPower(intA, intB));
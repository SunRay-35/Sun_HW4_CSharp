// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами.
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах). 
// Реализовать через функции. (* Доп сложность, “введите количество элементов массива”,
// “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)

// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 -> 8

int PromptInt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

int[] CreateArray(int Length, int Min, int Max)
{
    int[] tempArray = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        tempArray[i] = new Random().Next(Min, Max+1);
    }
    return tempArray;
}

void printArray(int[] intArray)
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}

System.Console.WriteLine("Данная программа принимает на размер массива N, минимальное Min и максимальное Max значение для генерации случайных чисел, создает массив заданной размерности случайными числами в заданном диапазоне.");
int intN = PromptInt("Введите размер массива - N: ");
int intMin = PromptInt("Введите минимальное значение случайного числа - Min: ");
int intMax = PromptInt("Введите максимальное значение случайного числа - Max: ");

System.Console.Write($"Случайный массив длиной {intN} со значениями от {intMin} до {intMax}: ");
int[] maxArray = CreateArray(intN, intMin, intMax);
printArray(maxArray);
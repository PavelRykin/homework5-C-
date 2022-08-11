/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Write("Введите размерность массива ");
int arrayLenght = int.Parse(Console.ReadLine());
int[] array = GetArray(arrayLenght);
Console.WriteLine("Это ваш сгенерированный массив!");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Количество четных чисел в данном массиве равно " + FindEvenNumbers(array));

int[] GetArray(int n)
{
    int[] array = new int[n];
    Random number = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = number.Next(100, 999);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int FindEvenNumbers(int[] array)
{
    int sumEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sumEven += 1;
        }
    }
    return sumEven;
}

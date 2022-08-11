/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Write("Введите размерность массива ");
int arrayLenght = int.Parse(Console.ReadLine());
int[] array = GetArray(arrayLenght);
Console.WriteLine("Это ваш сгенерированный массив!");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Сумма элементов стоящих на нечётных позициях равна " + FindSummNotEvenPos(array));

int[] GetArray(int n)
{
    int[] array = new int[n];
    Random number = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = number.Next(1, 10);
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

int FindSummNotEvenPos(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
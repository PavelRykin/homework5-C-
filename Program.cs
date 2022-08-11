/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Write("Введите размерность массива ");
int arrayLenght = int.Parse(Console.ReadLine());
double[] array = GetArray(arrayLenght);
Console.WriteLine("Это ваш сгенерированный массив!");
PrintArray(array);
Console.WriteLine();

double maxNumber = array[0];
double minNumber = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (maxNumber < array[i])
    {
        maxNumber = array[i];
    }
    if (minNumber > array[i])
    {
        minNumber = array[i];
    }
}

double difference = maxNumber - minNumber;

Console.WriteLine($"Разница между максимальным {maxNumber} и минимальным {minNumber} элементом массива равна {difference}");

double[] GetArray(int n)
{
    double[] array = new double[n];
    Random number = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = number.Next(0, 20);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


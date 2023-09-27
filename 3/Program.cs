// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
int size = Convert.ToInt32(Console.ReadLine()!);
double[] numbers = new double[size];
RandomNumbers(numbers);
PrintArray(numbers);
void RandomNumbers(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (new Random().Next(100, 1000) / 10.0);
    }
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
System.Console.WriteLine(numbers.Max() - numbers.Min());

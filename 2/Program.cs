// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
int size = 4;
int[] numbers = new int[size];
ArrayRandomNumbers(numbers);
PrintArray(numbers);

int sumNumbersOddIndex = 0;

for (int i = 0; i < numbers.Length; i += 2)
{
    sumNumbersOddIndex += numbers[i];
}
Console.Write(sumNumbersOddIndex);



void ArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
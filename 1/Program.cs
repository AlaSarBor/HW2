//задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// // которая покажет количество чётных чисел в массиве.
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int even = 0;
RandomNumbers(numbers);
PrintArray(numbers);


for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
        even++;
}


Console.WriteLine($"{even} ");

void RandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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


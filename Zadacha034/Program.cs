/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве. */

Console.WriteLine("Введите количество чисел в массиве");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 999);
}
Console.WriteLine(string.Join(", ", array));
int count = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0) count += 1;
}
Console.WriteLine($"Количество четных чисел в массиве {count}");

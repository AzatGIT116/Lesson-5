/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. */

Console.WriteLine("Введите количество случайных чисел");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];
Random rand = new Random();
double max = 0;
double min = 100;
for (int i = 0; i < array.Length; i++) array[i] = rand.Next(100);
for (int i = 0; i < array.Length; i++) 
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
for (int i = 0; i < array.Length; i++) Console.Write(" " + array[i]);
Console.WriteLine();
Console.WriteLine("max= " + max);
Console.WriteLine("min= " + min);
Console.WriteLine("Разница максимального и минимального:  " + (max - min));
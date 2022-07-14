/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

 Console.WriteLine("Введите количество случайных чисел"); 
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 100);
}
Console.WriteLine(string.Join(", ", array));

SumOfNumbersOfOddPosition(array);
void SumOfNumbersOfOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i] ;
    }
    Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях равна {sum}");
}
 

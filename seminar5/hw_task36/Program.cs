// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите нужное кол-во элементов в массиве:");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 1000);
}
Console.Write(string.Join(" ", array));
int summ = 0;
for(int i = 1; i < array.Length; i = i + 2)
{
    summ = array[i] + summ;
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях составляет {summ}");
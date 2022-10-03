// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int numberC = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB && numberA > numberC)
{
    Console.WriteLine($"Максимальное - {numberA}");
}
if (numberB > numberA && numberB > numberC)
{
    Console.WriteLine($"Максимальное - {numberB}");
}
if (numberC > numberA && numberC > numberB)
{
    Console.WriteLine($"Максимальное - {numberC}");
}
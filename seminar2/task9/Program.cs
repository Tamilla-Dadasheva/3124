﻿// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

Random rand = new Random();
int number = rand.Next(10, 100);
Console.WriteLine($"Сгенерировалось случайное число - {number}");
int digit1 = number / 10;
int digit2 = number % 10;
// Console.WriteLine(digit1);
// Console.WriteLine(digit2);
if (digit1 > digit2)
{
    Console.WriteLine($"Большее число - {digit1}");
}
else
{
    Console.WriteLine($"Большее число - {digit2}");
}
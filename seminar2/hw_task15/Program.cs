﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру:");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 1 && number <= 7)
{
    if(number <= 5)
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Выходной");
    }
}
else
{
    Console.WriteLine("Неверный ввод");
}
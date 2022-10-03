//  11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(100, 1000);
{
    Console.WriteLine($"Найдено случайное число {number}");
}
int digit1 = (number / 10) / 10;
int digit3 = number % 10;
Console.WriteLine("Новое число " + digit1 + digit3);
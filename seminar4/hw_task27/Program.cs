// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = ReadNumber("Введите число");
int result = 0;
if(number > 0)
{
    while(number != 0)
    {
        result = result + (number % 10);
        number = number / 10;
    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Число должно быть положительное");
}
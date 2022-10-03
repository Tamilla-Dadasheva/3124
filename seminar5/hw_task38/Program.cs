// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] array = {3, 7, 22, 2, 78};

int MaxElementArray(int[] array) 
{   
    int max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int MinElementArray(int[] array)
{   
    int min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}


Console.WriteLine(string.Join(", ", array));
Console.WriteLine();
int MaxNumber = MaxElementArray(array);
Console.WriteLine($"Максимальное число массива - {MaxNumber}");
Console.WriteLine();
int MinNumber = MinElementArray(array);
Console.WriteLine($"Минимальное число массива - {MinNumber}");
Console.WriteLine();
Console.WriteLine($"Разница составляет - {MaxNumber - MinNumber}");
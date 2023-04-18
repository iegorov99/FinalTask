﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите строку №{i + 1}: ");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    foreach (string item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

void NewArray(string[] array, string[] array2)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[k] = array[i];
            k++;
        }
    }
}

try
{
Console.WriteLine("Введите количество строк, которое хотети ввести: ");
int count = Convert.ToInt32(Console.ReadLine());
string[] array = new string[count];
string[] array2 = new string[count];
FillArray(array);
Console.WriteLine("Первоначальный массив");
PrintArray(array);
NewArray(array, array2);
Console.WriteLine("Массив из строк, длина которых меньше, либо равна 3 символам");
PrintArray(array2);
}
catch
{
    Console.WriteLine("Введено некрорректное значение!");
}
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать 
//на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using System;
using static System.Console;

Clear();

WriteLine("Введите набор строк через запятую");
string[] user = ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
ChooseMassiveElements(user);

void ChooseMassiveElements (string[] array)
{
    string[] newMassive = new string[array.Length];
    int k=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<=3)
        newMassive[k] = array[i];
        k++;
    }
    Write($"[{String.Join(", ", newMassive)}]");
}
/*
    Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
    длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
    либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
    лучше обойтись исключительно массивами.

    Примеры:
    [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
    [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
    [“Russia”, “Denmark”, “Kazan”] → []
*/

Console.Clear();

string[] GetStringArray()
{
    Console.Write("Write strings separated by commas ',' and press Enter: ");
    string str = Console.ReadLine()!;
    string[] array = str.Split(',');
    return array;
}

string[] FindStringsUpToThreeChar(string[] array)
{
    string threeCharStr = string.Empty;
    int count;

    for (int i = 0; i < array.Length; i++)
    {
        count = 0;
        for (int j = 0; j < array[i].Length; j++)
        {
            count++;
        }

        if (count <= 3)
        {
            threeCharStr += array[i] + ",";
        }
    }
    
    string[] newStrArray = threeCharStr.Split(',');
    return newStrArray;
}

string[] array = GetStringArray();
string[] threeCharStrArr = FindStringsUpToThreeChar(array);
Console.Write("[" + string.Join(',', threeCharStrArr).Trim(',') + "]");
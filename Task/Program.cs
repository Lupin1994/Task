// Задача Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры. либо 
// задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
void newArray(string[] Array, string[] NArray)
{
    int j = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            NArray[j] = Array[i];
            j++;
        }
    }
}
string[] Array = new string[7] { "hello", "2", "world", ":=)", "1234", "145", "-2j" };
string[] NArray = new string[Array.Length]; // NArray it is "new array"

newArray(Array, NArray);
PrintArray(NArray);

/*
Задача 29: Напишите программу, в которой пользователь задает длину массива, элементы которого задаются в диапазоне [1,99] и выводит на экран. 
То есть пользователь задает длинну массива, который заполнен рандомными числами от 1 до 99.

5 -> [1, 2, 5, 7, 19]

3 -> [6, 1, 33]
*/
Console.WriteLine("введите значение длины массива ");
int maxUserNumber = Convert.ToInt32(Console.ReadLine ());

int [] array = new int[maxUserNumber];

Console.Write($"Массив из {maxUserNumber} элементов:[");
for (int i = 0; i < maxUserNumber; i++)
{
    array [i] = new Random(). Next (1, 100);
    Console.Write(array [i]);
    if (i != maxUserNumber - 1)
    {
        Console.Write(",");
    }
}
Console.Write("]");

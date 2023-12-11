// Домашняя работа. 1 задача. Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] array = new int[10];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101); 
    Console.Write(array[i] + " ");
}

int count = 0;

Console.WriteLine();

for(int i =0; i<array.Length; i++)
{
    if(array[i] > 19 && array[i] < 91)
    count = count + 1;
}

Console.Write("Количество элементов " + count);



// Домашняя работа. 2 задача. Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = new int[10];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next();
    Console.Write(array[i] + " ");
}
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i]%2 == 0)
    count = count + 1;
}
Console.WriteLine("Четных чисел = " + count);




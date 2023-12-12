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



// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[10];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
    Console.Write(array[i].ToString("F2") + " ");
}

double max = array[0];
double min = array[0];

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }
    if(array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine();

string smax = max.ToString("F2");
string smin = min.ToString("F2");
Console.WriteLine("Max " + smax);
Console.WriteLine("Min " + smin);

double result = max - min;
string res = result.ToString("F2");

Console.WriteLine("Разница между макс. и мин. элементом массива = " + res);



// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива должен быть равен количеству цифр.
// 
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num + 1];
array[0] = num/10;

for(int i = num; i < array.Length; i--)
{
    if(num > 1 && num < 100001)
    {
        array[i] = num%10;
        num = num/10;
    }
}
for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] +" ");
}

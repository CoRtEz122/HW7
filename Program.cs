// Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


// Console.WriteLine("Введите число");

// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int colums = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double [rows,colums];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().NextDouble()*100;

//        Console.Write("{0,6:F2}", array[i, j]);
        
//     }
    
//     Console.WriteLine();
// }



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите Размер массива");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Размер массива");
// int colums = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int [rows,colums];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(-100,101);
//        Console.Write(array[i, j]+" ");

//     }
    
//     Console.WriteLine();
// }

// Console.WriteLine("Введите первую позицию числа");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите вторую позицию числа");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if ((num1>rows) || (num2>colums))
// {
//     Console.WriteLine("Такого числа нет");
// }
// else
// {
//     object c = array.GetValue(num1,num2);
//  Console.WriteLine(c);
// }



// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца:
//  4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите Размер массива");
int rows = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int [rows];
Console.WriteLine("Введите Размер массива");
int colums = Convert.ToInt32(Console.ReadLine());
int[] array2 = new int [colums];
int result1 = 0;
int result2 = 0;

for (int i = 0; i < array1.Length; i++)
{
    array1[i] = new Random().Next(0,101);
}

for (int i = 0; i < array1.Length; i++)
{
    array2[i] = new Random().Next(0,101);
}

    for (int i = 0; i < array1.Length; i++)
    {
        result1 = result1 + array1[i];
    }

    for (int i = 0; i < array2.Length; i++)
    {
        result2 = result2 + array2[i];
    }
    Console.WriteLine(string.Join(",",array1));
    Console.WriteLine(string.Join(",",array2));
    Console.WriteLine("среднее арифметическое элементов 1 строки; "+ result1);
    Console.WriteLine("среднее арифметическое элементов 2 строки; "+ result2);
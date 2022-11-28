/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/


/*

int[,] Massiv(int a, int b, int min, int max)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");

        }
        Console.WriteLine();
    }
}
/*
void ChangeArray(int[,] array)
{
    for( int i = 0; i < array.GetLength(0); i++)
    {
        for( int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for( int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if( array[i, k] < array[i, k + 1]) 
                {
                    int temp = 0;
                    temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;

                }
            }
        }
    }
}
 Console.WriteLine("Введите число строк :");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());
int[,] MyArray = Massiv(n,m, min, max);
ShowArray(MyArray);
Console.WriteLine();
Console.WriteLine("А вот и новый массив");
Console.WriteLine();
ChangeArray(MyArray);
ShowArray(MyArray);
*/


/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/
/*
int SumElementov(int[,] array)
{
    int minSumElements = 0;
    int indexRow = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int SumElements = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumElements = SumElements + array[i, j];
        }
        Console.Write(SumElements + " ");
        if (SumElements > minSumElements)
        {
            minSumElements = SumElements;
            indexRow++;
        }
    }
    return indexRow;
}

Console.WriteLine("Введите число строк :");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());
int[,] MyArray = Massiv(n, m, min, max);
ShowArray(MyArray);
Console.WriteLine();
SumElementov(MyArray);
int Z = SumElementov(MyArray);
Console.WriteLine($" {Z} ");
*/


/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/
/*
int[,,] Massiv3(int a, int b, int c)
{
    int[,,] array = new int[a, b, c];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                array[i, j, k] = new Random().Next(10, 99 + 1);
            }
        }
    }
    return array;
}
void ChangArray(int[,,] array)
{
    int indexMax = array[0, 0, 0];
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    if (array[i, j, k] > indexMax)
                    {
                        indexMax = array[i, j, k];
                    }
                }
            }
        }
    }
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    for (int l = 1; l < array.GetLength(1); l++)
                    {
                        if (array[i, j, k] == array[i, l, k])
                        {
                            indexMax--;
                            array[i, j, k] = indexMax;
                            break;
                        }
                    }
                }
            }
        }
    }


    void ShowArray(int[,,] array)
    {

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine(" *********************");
            Console.WriteLine("Номер массива " + (i + 1));
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.WriteLine();
                for (int k = 0; k < array.GetLength(2); k++)
                    Console.Write(array[i, j, k] + "  " + (i, j, k) + " ");

            }
            Console.WriteLine();
        }
    }
    Console.WriteLine("Введите высоту массива :");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите ширину массива :");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите глубину массива :");
    int p = Convert.ToInt32(Console.ReadLine());
    int[,,] MyArray = Massiv3(n, m, p);
    Console.WriteLine();
    ChangArray(MyArray);
    ShowArray(MyArray);
*/


/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.*/
int[,] NewArray()
{
    int[,] array1 = { { 1, 2 }, { 1, 2 } };
    int[,] array2 = { { 1, 2 }, { 1, 2 } };
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write(array1[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("===============");
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write(array2[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("===============");
    int[,] matrix = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int a = 0; a < array2.GetLength(1); a++)
            {
                for (int b = 0; b < array2.GetLength(0); b++)
                {
                    matrix[i, j] += array1[i, j] * array2[a, b];
                }
            }
        }
    }
    return matrix;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");

        }
        Console.WriteLine();
    }
}
ShowArray(NewArray());

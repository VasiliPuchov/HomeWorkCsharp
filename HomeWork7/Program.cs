/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/
/*
double[,] Massiv(int a, int b, int min,int max){
    double[,] array = new double[a, b];
    for(int i = 0; i < a; i++){
        for( int j = 0; j < b; j++){
        array[i,j] = new  Random().Next(min, max +1) + new Random().NextDouble();
         }
    }
    return array;
}
void ShowArray(double[,] array ){
for( int i = 0; i < array.GetLength(0); i++){
    for( int j = 0; j < array.GetLength(1); j++){
        Console.Write( array[i,j] + " ");
        }
Console.WriteLine();
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
double[,] MyArray = Massiv(n,m, min, max);
ShowArray(MyArray);
*/

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
*/

int[,] Massiv(int a, int b, int min,int max){
    int[,] array = new int[a, b];
    for(int i = 0; i < a; i++){
        for( int j = 0; j < b; j++){
        array[i,j] = new  Random().Next(min, max +1);
         }
    }
    return array;
}
void ShowArray(int[,] array ){
for( int i = 0; i < array.GetLength(0); i++){
    for( int j = 0; j < array.GetLength(1); j++){
        Console.Write( array[i,j] + " ");
   
        }
        Console.WriteLine();
    }
}
/*
void FindIndex(int [,] array, int x, int y){
    
               if( x < array.GetLength(0) && y < array.GetLength(1)){
                Console.WriteLine($" Вы попали  в {array[x,y]} , хорошее попадание" );
               }
               else{
                Console.WriteLine("Нет,нет вы не попали в массив !!!");
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
Console.WriteLine("Введите  индекс строки  :");
int index1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца :");
int index2 = Convert.ToInt32(Console.ReadLine());
int[,] MyArray = Massiv(n,m, min, max);
ShowArray(MyArray);
FindIndex(MyArray,index1, index2);*/

/*Задача 52. Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.*/

 void SumElemrnts(int[,] array){
    for( int j = 0; j < array.GetLength(1); j++){
        double sum = 0;
        for( int i = 0; i < array.GetLength(0); i++){
            sum += array[i, j];
        }
        sum = sum/ array.GetLength(0);
        Console.Write($"{sum} ");
    }
 }

    
 /*double[] SumArray( double sum){
    
    double[] array = new double[sum] ;
    
 return array;
  void ShowArray2(double[] array){
        for(int i = 0; i < array.Length; i++){
            Console.Write( array[i] + " " ) ;
        }
    } */
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
SumElemrnts(MyArray);

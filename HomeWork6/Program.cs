/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.*/
/*
   int[] Massiv(int size){
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
    return array;
}
    void ShowArray(int[] array){
        for(int i = 0; i < array.Length; i++){
            Console.Write(array[i] + " ");
        }
    } 
int Sum( int[] array){
    int count = 0;
    for( int i = 0; i < array.Length; i++){
        if( array[i] > 0){
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите какое количество чисел вы хотите ввезти ? : ");
int M = Convert.ToInt32(Console.ReadLine());
int[] My = Massiv(M);
ShowArray(My);
Console.WriteLine($"В вашем массиве из {M} элементов , всего {Sum(My)} положительных  ");
*/
/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/

 double[] FindPunkt(int k1, int k2, int b1, int b2){
    double x = (b2 -b1) / (k1 - k2);
    double y = k1 * x + b1;
    double[] array = new double[2] ;
    array[0] = x;
    array[1] = y;
 return array;
 }
   void ShowArray(double[] array){
        for(int i = 0; i < array.Length; i++){
            Console.Write( array[i] + " " ) ;
        }
    } 
Console.WriteLine("Введите значение k1 : ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2 : ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b1 : ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2 : ");
int b2 = Convert.ToInt32(Console.ReadLine());
double[] myArray = FindPunkt(k1, k2, b1, b2);
ShowArray(myArray);


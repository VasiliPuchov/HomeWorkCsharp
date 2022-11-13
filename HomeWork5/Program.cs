/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
*/
/*
int[] Massiv(int size){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(100, 1000 );
    }
    return array;
}
    void ShowArray(int[] array){
        for(int i = 0; i < array.Length; i++){
            Console.Write(array[i] + " ");
        }
    }

int Vsego(int[] array){
    int count = 0;
    for(int i = 0; i < array.Length ; i++){
        if(array[i] %2 == 0 ){
            count ++;
        }
    }
    return count;
}
   Console.WriteLine("Введите размер массива : " );
int x = Convert.ToInt32(Console.ReadLine());
int[] myArray =Massiv(x);
ShowArray(myArray);
Console.WriteLine();
Console.WriteLine(Vsego(myArray));
*/
/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/
/*
int[] Massiv1( int size, int min, int max){
        int[] array = new int[size];
        for( int i = 0; i < size; i++){
            array[i] = new Random().Next(min, max + 1);
        }
        return array;
    }
void ShowArray1(int[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
}
int Sum( int[] array){
    int sum = 0;
    for( int i = 1; i < array.Length; i+=2){
            sum =sum + array[i];
        }
    return sum;
}
Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());
int[] MyArray = Massiv1(n, min, max);
ShowArray1(MyArray);
int ResSum = Sum(MyArray);
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива состоящих из {n} элементов стоящих на нечетных позициях равна {ResSum}  ");
*/
/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.*/

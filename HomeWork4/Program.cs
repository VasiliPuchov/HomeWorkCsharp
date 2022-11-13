/*Задача 25: Напишите цикл, который принимает на вход
 два числа (A и B) и возводит число A в натуральную степень B.*/
 /*int Znak(int A, int B){
    int res = 1;
    for(int i = 1;i <= B; i++){
      res *= A; 
    }
    return res;
 }
Console.WriteLine("Введите первое число : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе  число : ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы хотели узнать , если число {x} возвести в стпень {y} получиться число {Znak(x, y)} ВОТ ТАК !!!   ");
*/

//*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int NumberSum(int number){
    int sum = 0;
    int x;
    while(number > 0){
        x = number % 10;
        number = number / 10;
        sum = sum + x;
        
    }
    return sum;
}
Console.WriteLine("Введите число: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"ВЫ хотели узнать сумму цифр ищ вашего числа {z} ,вот оно {NumberSum(z)}  ");
*/

//*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
void NEW(int[] numbers){
    int lenght = numbers.Length;
    for(int index = 0;index < lenght; index++){
        numbers[index] = new Random().Next(1, 8);
    }
    
}
void Print(int[] col){
    int count =col.Length;
    for(int posion = 0;posion < count;posion++){
        Console.WriteLine(col[posion]);
    }
}

int [] modul =new int[8];
NEW(modul);
Print(modul);
*/


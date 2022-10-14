// Домашнее задание номер 1
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое
//  число большее, а какое меньшее.

/*Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max;
if(number1 > number2){
    max = number1;
}
else{
    max = number2;
};
Console.WriteLine($"Максимальное число {max}");*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());
int MAX;
if(number1 > number2 && number1 > number3){
    MAX = number1;
}
else if(number2 > number1 && number2 > number3){
    MAX = number2;
}
else{
    MAX = number3;
};
Console.WriteLine($"Максимальное число {MAX}");
*/

/*Задача 6: Напишите программу, которая на вход принимает
 число и выдаёт, является ли число чётным (делится ли оно на два без остатка).*/

 /*Console.WriteLine("Введите число: ");
 int number = Convert.ToInt32(Console.ReadLine());
 if(number % 2 == 0){
    Console.WriteLine($"Ваше число {number} четное ,оно делиться на два без остатка");
 }
 else{
    Console.WriteLine($"Ваше число {number} не четное !!!");
 }*/

 /*Задача 8: Напишите программу, которая на вход принимает 
 число (N), а на выходе показывает все чётные числа от 1 до N.*/

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int numbers = 1;
while( numbers <= N){
    if(numbers % 2 == 0){
        Console.WriteLine($"Вот все четные числа {numbers}  ");
       
    }
    numbers = numbers + 1;
}




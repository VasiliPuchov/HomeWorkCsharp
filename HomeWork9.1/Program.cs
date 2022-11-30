/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
 Выполнить с помощью рекурсии.*/
/*
void  ShowNumbres( int N)
{
    Console.Write(N + " ");
    if( N > 1 ) ShowNumbres( N - 1);
    
    
}

Console.WriteLine("Введите число :");
int X = Convert.ToInt32(Console.ReadLine());
ShowNumbres(X);
*/

/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.*/
/*
int SumNumbers(int m, int n)
{
    if (n >= m) return  n + SumNumbers(m, n - 1);
    else return n + SumNumbers(m, n + 1);
}
Console.WriteLine("Введите число :");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число :");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(x, y));
*/

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.*/
/*
int FunAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return FunAkkerman(m - 1, 1);
    if (m > 0 && n > 0) return FunAkkerman(m - 1, FunAkkerman(m, n - 1));
    return FunAkkerman(n, m);
}
Console.WriteLine("Введите число :");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число :");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FunAkkerman(x, y));
*/

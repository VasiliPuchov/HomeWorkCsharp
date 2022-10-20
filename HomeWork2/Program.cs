/*Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.*/
/*
int SecondNumber( int number){
    int second = (number / 10) % 10; 
    
return second;
}
    
Console.WriteLine("Введите  любое трехзначное число от 100 до 999 ");
int YourNumber = Convert.ToInt32(Console.ReadLine());
int resultat = SecondNumber(YourNumber);
Console.WriteLine($"Вы ввели число {YourNumber} , вторая цифра вашего числа {resultat} ");
*/

/*Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, что третьей цифры нет*/
/*
int ThreeNumber( int number){
    while( number > 999){
        number = number /10;
    }
    number = number %10;
return number;
}
Console.WriteLine("Введите ваше любимое число  ");
int YourLoveNumber = Convert.ToInt32(Console.ReadLine());
int res;
if(YourLoveNumber <= 99){
    Console.WriteLine($"ОЙ -ОЙ у вашего любимого числа {YourLoveNumber} нет третьей цифры ");
}
    else{
        res = ThreeNumber(YourLoveNumber);
        Console.WriteLine($"Ваше люимое число  {YourLoveNumber} третья цифра этого числа {res} ");
    }
*/
 
 /*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую
  день недели, и проверяет, является ли этот день выходным.*/
/*
  bool Weekend( int number){
    bool res;
   if(number == 6 || number == 7){
        res = true;
        
   }
else{
      res = false;  
}
return res ;
  }
Console.WriteLine("Введите число от 1 до 7 , что бы узнать выходной сегодня или нет ");
int days = Convert.ToInt32(Console.ReadLine());
bool day = Weekend(days);
Console.WriteLine(day);
*/
/* Домашнее задание номер 3
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом*/
/*
bool Palindrome(string number){
    if(number[0] == number[4] && number[1] == number[3]){
        return true;
    }
    else{
        return false;
    }
}
Console.WriteLine("Введите пятизначное число ");
string  num = Console.ReadLine();
bool res = Palindrome(num);
Console.WriteLine(res);
*/
/*Задача 21
Напишите программу, которая
 принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.*/
/*
 double ABC( double x1, double x2, double y1, double y2, double z1, double z2){
    double x = x2*x2 - x1 * x1;
    double y = y2 * y2 - y1 * y1;
    double z = z2 * z2 - z1 * z1;
    double distaion = x + y + z;
    distaion = Math.Sqrt(distaion);
    return distaion;
 }
 Console.WriteLine("Введите координаты первой точки по оси X");
 double x = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координаты первой точки по оси Y");
 double y = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите координаты первой точки по оси Z");
 double z = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите координаты второй точки по оси X");
 double x1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координаты второй точки по оси Y");
 double y1 = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите координаты второй точки по оси Z");
 double z1 = Convert.ToInt32(Console.ReadLine());
 double resultat = ABC(x, y, z, x1, y1, z1);
 Console.WriteLine($"Растояние между двумя точками , всегда прямая :) , а  растояние между вашими точками {resultat} ");
*/

/*

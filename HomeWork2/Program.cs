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

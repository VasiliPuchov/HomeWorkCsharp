/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

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

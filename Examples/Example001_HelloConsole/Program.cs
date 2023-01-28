// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! 1");

/*
Урок 1. Знакомство с языком программирования С#
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Урок 1. Домашнее заданиею");

int a = 5;
int b = 7;
int Max2Numbers(int a, int b){
    int result = a;
    if(b>result) result = b;
    return result;
}
int max2 = Max2Numbers(a,b);

//Интерполяция https://learn.microsoft.com/ru-ru/dotnet/csharp/tutorials/string-interpolation
Console.WriteLine($"Задача 2: Число {max2} наибольшее из предоставленных двух чисел {a} и {b}.");

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int c = 2;
int d = 3;
int e = 7;

int Max3Numbers(int a, int b, int c){
    int result = a;
    if(b>result) result = b;
    if(c>result) result = c;
    return result;
}

int max3 = Max3Numbers(c,d,e);

//Интерполяция https://learn.microsoft.com/ru-ru/dotnet/csharp/tutorials/string-interpolation
Console.WriteLine($"Задача 4: Число {max3} наибольшее из предоставленных трех чисел {c},{d} и {e}.");

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

int f = 7;

string Chet(int a){
    string result = String.Empty;
    if ( a != 0 && a != 1 && a != -1 && a % 2 == 0 )
        result = "Да";
    else 
        result = "Нет";
    return result;
}

Console.WriteLine($"Задача 6: Является ли число {f} четным? Ответ: {Chet(f)}");

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int h = 13;
int index = 1;
Console.WriteLine($"Задача 8: Напишите программу, которая на вход принимает число ({h}), а на выходе показывает все чётные числа от 1 до {h}.");
while( index <= h )
{
    if (Chet(index) == "Да"){
        Console.WriteLine($"{index}");
        index++;
    } else
        index++;
}


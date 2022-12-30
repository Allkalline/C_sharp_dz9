/* Задайте значение N. Напишите программу, которая выведет все натуральные
 ЧЕТНЫЕ числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);

string PrintNumb(int i, int N)
{ 
    if( i<=N) return PrintNumb(i+2, N) + $"{i} ";
    else return String.Empty;
}
Console.Write(PrintNumb(2,n));
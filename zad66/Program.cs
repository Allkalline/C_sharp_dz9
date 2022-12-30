/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);

int PrintNumb(int i, int N)
{ 
    if( i<N) return i + PrintNumb(i+1, N);
    else return i;
}
Console.Write(PrintNumb(m,n));
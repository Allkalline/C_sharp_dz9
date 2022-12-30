/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);

int fAccer(int m, int n)
{ 
    if(m==0) return n+1;
    else if (n==0 && m != 0) return fAccer(m-1,1);
    else if (m>0 && n>0) return fAccer(m - 1, fAccer(m, n - 1));
    return fAccer(m, n);
}
Console.Write(fAccer(m,n));
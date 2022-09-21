// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

/* Решение внутри

void OutputOfNumbers (int m, int n)
{
    if ((m > n) )
    {
        Console.Write(n + " ");
        n = n +1;
        OutputOfNumbers(m, n);
    }
    if ((m < n) )
    {
        Console.Write(m + " ");
        m = m +1;
        OutputOfNumbers(m, n);
    }
}

Console.Write("Пожалуйста введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m>n) m=m+1;
if (n>m) n=n+1;

Console.Write(" -> ");
OutputOfNumbers(m, n);
Console.WriteLine("");

*/


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/* Решение внутри

int OutputOfNumbers (int m, int n)
{
    if (m > n )
    {
        //n = n +1;
        return n = n +OutputOfNumbers(m, n+1);
    }
    if ((m < n) )
    {
        //m = m +1;
        return m = m + OutputOfNumbers(m+1, n);
    }
    return 0;
}

Console.Write("Пожалуйста введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
 if (m>n) m=m+1;
 if (n>m) n=n+1;

Console.Write(" -> " + (OutputOfNumbers(m, n)));
Console.WriteLine("");

*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

/* Решение внутри

int Akkerman (int m, int n)
{
    if (m==0)
    {
        return n+1;
    }
    if (m!=0 && n==0)
    {
        return Akkerman(m-1, 1);
    }
    if (n>0 && m > 0 )
    {
        return Akkerman(m-1, Akkerman(m, n-1));
    }
    else return 0;
    
}

Console.Write("Пожалуйста введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" -> " + Akkerman(n, m));

*/


// Задача 68:
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Использовал псевдокод с сайта https://ru.wikipedia.org/wiki/Функция_Аккермана#Реализация
int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m -1, 1);
    else return Ackermann(m -1, Ackermann(m, n -1));
}

int Ackermann2(int m, int n)
{
    while (m != 0)
    {
        if (n == 0) n = 1;
        else n = Ackermann2(m, n - 1);
        m = m - 1;
    }
    return n + 1;
}

System.Console.WriteLine(Ackermann(2, 3));
System.Console.WriteLine(Ackermann(3, 2));
System.Console.WriteLine(Ackermann2(2, 3));
System.Console.WriteLine(Ackermann2(3, 2));
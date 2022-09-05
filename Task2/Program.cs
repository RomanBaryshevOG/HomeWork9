//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29


int m = InputInt("Введите положительное число M: ");
int n = InputInt("Введите положительное число N: ");

Console.WriteLine($" m = {m}, n = {n} -> A(m,n) = {AckermanFunction(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;

    if (m > 0 && n == 0) return AckermanFunction(m - 1, 1);

    else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}
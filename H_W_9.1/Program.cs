// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа 
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

using static System.Console;
Clear();
int M = InputUser("Введите число M");
int N = InputUser("Введите число N");
System.Console.WriteLine();
System.Console.Write("Чётные натуральные числа от M от N: ");
int InputUser(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}
void GetNaturalEvenNumbers(int M, int N)
{
// if (M < N) Console.Write("ошибка"); // не понял как исключить ситуацию когда при вводе получется M<N
    if (M > N) return;
    if (M % 2 == 0) Console.Write($"{M}, ");
    GetNaturalEvenNumbers(M + 1, N);
    
}

GetNaturalEvenNumbers(M, N);

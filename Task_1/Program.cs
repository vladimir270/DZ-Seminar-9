// Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N

Console.WriteLine("Введите число M ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNamber(int M, int N)
{
    int sum = 0;
    if (M <= N)
    {
       sum = sum + M;
       sum+= SumNamber(M+1, N);
        
    }
    return sum;
}


Console.WriteLine($"Сумма чисел в промежутке = {SumNamber(M,N)}");
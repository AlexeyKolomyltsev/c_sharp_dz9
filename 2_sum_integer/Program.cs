///Найти сумму элементов от M до N, N и M заданы
int SumOfMN(int m, int n)
{   
    if(m == n) return m;
    return m + SumOfMN(m + 1, n);
}

Console.Write("Put number M ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Put number N ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"Сумма чисел от {m} до {n}: " );
int sum = SumOfMN(m,n);
Console.WriteLine(sum);

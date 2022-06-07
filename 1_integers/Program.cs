///Показать натуральные числа от M до N, N и M заданы
void Posledovatelnost(int m, int n)
{
    Console.Write(m + " ");
    if(m < n) Posledovatelnost(m + 1, n);
}

Console.Write("Put number M ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Put number N ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Последовательность чисел: " );
Posledovatelnost(m,n);
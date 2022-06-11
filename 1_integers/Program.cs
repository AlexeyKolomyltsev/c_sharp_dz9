///Показать натуральные числа от M до N, N и M заданы
string Posledovatelnost(int m, int n)
{
    if(m == n) return m.ToString();
    return m.ToString() + " " + Posledovatelnost(m + 1, n);
}

Console.Write("Put number M ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Put number N ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Последовательность чисел: " );
Console.WriteLine(Posledovatelnost(m,n));
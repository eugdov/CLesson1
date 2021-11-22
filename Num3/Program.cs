Console.WriteLine("Введите первое число: ");
string a = Console.ReadLine();
double aa = Convert.ToDouble(a);
Console.WriteLine("Введите второе число: ");
string b = Console.ReadLine();
double bb = Convert.ToDouble(b);
if (aa > bb)
{
    Console.WriteLine("Первое число больше второго");
}
if (aa < bb)
{
    Console.WriteLine("Первое число меньше второго");
}
if (aa == bb)
{
    Console.WriteLine("Первое и второе числа равны");
}
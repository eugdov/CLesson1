Console.WriteLine("Введите первое число: ");
string a = Console.ReadLine();
double aa = Convert.ToDouble(a);
Console.WriteLine("Введите второе число: ");
string b = Console.ReadLine();
double bb = Convert.ToDouble(b);
if (aa == Math.Sqrt(bb))
{
    Console.WriteLine("Да, первое число является корнем второго");
}
else
{
    Console.WriteLine("Нет, первое число не является корнем второго");
}

/*Console.WriteLine("Введите первое число: ");
string a = Console.ReadLine();
double aa = Convert.ToDouble(a);
Console.WriteLine("Введите второе число: ");
string b = Console.ReadLine();
double bb = Convert.ToDouble(b);
if (bb == aa*aa)
{
    Console.WriteLine("Да, первое число является корнем второго");
}
else
{
    Console.WriteLine("Нет, первое число не является корнем второго");
}
*/
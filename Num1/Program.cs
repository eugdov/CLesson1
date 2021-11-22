Console.WriteLine("Введите своё число: ");
string a = Console.ReadLine();
double aa = Convert.ToDouble(a);
Console.WriteLine("Введите степень числа: ");
string b = Console.ReadLine();
double bb = Convert.ToDouble(b);
double c = Math.Pow(aa, bb);
Console.WriteLine(c);
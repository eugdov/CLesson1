Console.WriteLine("Введите номер недели: ");
string a = Console.ReadLine();
double aa = Convert.ToDouble(a);
if (aa == 1)
{
    Console.WriteLine("Понедельник");
}
if (aa == 2)
{
    Console.WriteLine("Вторник");
}
if (aa == 3)
{
    Console.WriteLine("Среда");
}
if (aa == 4)
{
    Console.WriteLine("Четверг");
}
if (aa == 5)
{
    Console.WriteLine("Пятница");
}
if (aa == 6)
{
    Console.WriteLine("Суббота");
}
if (aa == 7)
{
    Console.WriteLine("Воскресенье");
}
if (aa < 1 || aa > 7)
{
    Console.WriteLine("Такого порядкового номера дня недели не существует, выберите число от 1 до 7");
}
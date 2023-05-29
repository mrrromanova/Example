Console.Clear();
Console.WriteLine("Введите число a: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int numberB = int.Parse(Console.ReadLine());

if (numberB == Convert.ToInt32(Math.Sqrt(numberA)))
{
    Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}
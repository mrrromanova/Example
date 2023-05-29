Console.Clear();
Console.Write("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine());
int B = number%10;
Console.WriteLine($"Последняя цифра этого числа: {B}");
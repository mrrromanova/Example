Console.Clear();
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());
int B = -N;
int count = B;
while (B<=N)
{
    Console.Write($"{B} ");
    B++;
}
Console.WriteLine("Введіть перше число:");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть друге число:");
int Y = int.Parse(Console.ReadLine());

int sum = 0;

if (X > Y)
{
    for (int i = Y; i <= X; i++)
    {
        sum += i;
    }

}
else if (Y > X)
{
    for (int j = X; j <= Y; j++)
    {
        sum += j;
    }

}
else
{
    sum = X;
}


Console.WriteLine($"Сума чисeл: {sum}");
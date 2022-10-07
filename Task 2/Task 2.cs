try
{
    Console.WriteLine("Введіть перше число:");
    int X = int.Parse(Console.ReadLine());
    Console.WriteLine("Введіть друге число:");
    int Y = int.Parse(Console.ReadLine());
}
catch 
{
    Console.WriteLine("Invalid input");
}
static void Main(string[] args)
{
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    int Sum = int.Parse(Console.ReadLine());
    int Substract = int.Parse(Console.ReadLine());

    int sum = Sum(x, y);
    Console.WriteLine("sum is: " + sum);

    int substract = Substract(x, y);
    Console.WriteLine("Substract is " + substract);
}

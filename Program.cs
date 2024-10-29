class Lab
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите значение переменной a");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение переменной b");
        int b = int.Parse(Console.ReadLine());
        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"a={a}, b={b}");
    }
    
}
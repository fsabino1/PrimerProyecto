internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string a;
        string b;

        a = Console.ReadLine();
        b = Console.ReadLine();

        int c = Convert.ToInt32(a);
        int d = Convert.ToInt32(b);

        Console.WriteLine(c + d);
    }
}
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

        Console.WriteLine("La seuma de a + b es: " + (c + d));

        const double NPI = 3.14;

        int e = int.Parse(Console.ReadLine());

        Console.WriteLine("Pi x ultimo ingreso");
        Console.WriteLine(NPI * e);

        double suma = NPI * e;

        Console.WriteLine($"Para poder meter la variable {suma}");


    }

}
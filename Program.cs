internal class Program
{
    private static void Main(string[] args)
    {
        //Clase 1
        
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

        //Clase 2
        bool check = NPI > 2;
        if (check)
        {
            Console.WriteLine("NPI es mayor a 2");
        }
        else
        {
            Console.WriteLine("NPI es menor a 2");
        }

        int compara = 4;

        if (compara == 3)
        {
            Console.WriteLine("Compara es igual a 3");
        }
        else
        {
            Console.WriteLine("Compara es distinto de 3");
        }
        //ELSE IF PARA VOLVER A CHEQUEAR
        if (compara == 3)
        {
            Console.WriteLine("Compara es igual a 3");
        }
        else if(compara == 4)
        {
            Console.WriteLine("Compara es distinto de 4");
        }
        else
        {
            Console.WriteLine("Compara es distinto de 4 y de 3");
        }
        
        Console.WriteLine("Ingrese su contraseña deseada");
        string contrasenia = Console.ReadLine();
        Console.WriteLine("Confirme la contraseña");
        string cconfirma = Console.ReadLine();

        if (contrasenia == cconfirma && contrasenia.Length > 7)
        {
            Console.WriteLine("Contraseña correcta");
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta, ingrese nuevamente la confirmación");
            cconfirma = Console.ReadLine();
            if (contrasenia == cconfirma && contrasenia.Length > 7)
            {
                Console.WriteLine("Contraseña válida al segundo intento");
            }
            else
            {
                Console.WriteLine("Contraseña inválida, ha sido expulsado del sistema");
            }
        }


    }

}
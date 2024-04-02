namespace Kontrollstrukturen03;

class Program
{
    static double Potenz(double basis, int exponent)
    {
        double result = 1;

        if (exponent == 0)
        {
            return result;

        }else
        {
            for (int i = 1; i <= exponent; i++)
            {
                result *= basis;
            }

            return result;
        }
    }

    static double PotenzRek(double basis, int exponent)
    {
        if (exponent == 0)
        {
            return 1;

        }else
        { 
                return basis * PotenzRek(basis, exponent-1);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Basis eingeben: ");
        double basis = Convert.ToDouble(Console.ReadLine());
        Console.Write("Exponent eingeben: ");
        int exponent = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{basis}^{exponent} = {Potenz(basis, exponent)}");

        Console.WriteLine($"\nAlle Potenzen von {basis}^0 bis {basis}^{exponent} ausgeben.");
        for(int i = 0; i <= exponent; i++)
        {
            Console.WriteLine($"{basis}^{i} = {Potenz(basis, i)}");
        }

        Console.WriteLine("\nRekursive Variante");
        Console.WriteLine($"{basis}^{exponent} = {PotenzRek(basis, exponent)}");
    }
}




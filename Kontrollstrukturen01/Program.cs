namespace Kontrollstrukturen01;

class Program
{

    static int Twist(int zahl)
    {   
        int twist = 0;
        
            do
            {
                int ziffer = zahl % 10;
                twist = twist * 10 + ziffer;
                zahl /= 10;

            } while (zahl > 0);

            return twist;

    }
    static void Main(string[] args)
    {
        Console.WriteLine($"Umgekehrte Zahl: {Twist(4567)}");
        Console.WriteLine($"Umgekehrte Zahl: {Twist(1234567890)}");

    }
}


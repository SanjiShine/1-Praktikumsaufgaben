namespace Kontrollstrukturen01;

class Program
{

    static int Twist(int zahl)
    {   
        int umgekehrte = 0;
        
            do
            {
                int ziffer = zahl % 10;
                umgekehrte = umgekehrte * 10 + ziffer;
                zahl /= 10;

            } while (zahl > 0);

            return umgekehrte;
    }
    static void Main(string[] args)
    { 
        Console.WriteLine($"Umgekehrte Zahl: {Twist(4567)}"); 
        Console.WriteLine($"Umgekehrte Zahl: {Twist(1234567890)}"); 

    }
}


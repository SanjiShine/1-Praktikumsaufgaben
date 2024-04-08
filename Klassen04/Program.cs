namespace Klassen04;

class Account
{
    string kontoinhaber;
    double guthaben;
    int kontonummer;
    static int kontonummerLatest = 11110;
    static double limit = 200.00;
    

    public Account(string kontoinhaber, double guthaben = 0.00)
    {
        this.kontoinhaber = kontoinhaber;
        this.guthaben = guthaben;
        this.kontonummer = ++kontonummerLatest;
    }

    public void Withdraw(double abheben)
    {

        if(this.guthaben- abheben < -limit)
        {
            Console.WriteLine($"Sie haben {this.guthaben} Euro auf Ihrem Konto.");
            Console.WriteLine("Geldabheben: 0.00\n");
        }
        else
        {   
            Console.WriteLine($"Geldabheben {abheben} von der Kontonummer {this.kontonummer} von {this.kontoinhaber}\n");
            this.guthaben -= abheben;
        }
        
    }

    public int GetKontonummer()
    {
        return this.kontonummer;
    }

    public void Deposit(double einzahlen)
    {
        if (einzahlen <= 0)
        {
            throw new ArgumentException("Geldeinzahlen nicht möglich!"); 
        }
        else
        {
            Console.WriteLine($"Geldeinzahlen {einzahlen} Euro auf dem Konto {this.kontonummer} von {this.kontoinhaber}\n");
            this.guthaben += einzahlen;
        }

    }

    static double GetLimit()
    {
        return limit;
    }

    static void LimitUpdate(double newLimit)
    {
        limit = newLimit;
    }

    public override string ToString()
    {
        return $"Kontonummer: {kontonummer}\nKontoinhaber: {kontoinhaber}\nGuthaben: {guthaben} Euro\n";
    }

    static void Main(string[] args)
    {
        Account a1 = new Account("San", 200);
        Account a2 = new Account("San Shine");

        Console.WriteLine(a1);
        a1.Withdraw(150);
        Console.WriteLine(a1);

        Console.WriteLine(a2);
        a2.Deposit(250);
        Console.WriteLine(a2);

    }


}


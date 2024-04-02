namespace Aufgabe04_Account;

class Account
{
    int kontonummer;
    string kontoinhaber;
    double guthaben;
    static double limit = 200;


    public Account(int kontonummer, string kontoinhaber, double guthaben = 0.0)
    {

        string check = Convert.ToString(kontonummer);

        if (check.Length != 10)
        {
            throw new ArgumentException("Kontonummer muss 10 Ziffer sein!");
        }

        this.kontonummer = kontonummer;
        this.kontoinhaber = kontoinhaber;
        this.guthaben = guthaben;


    }

    public static void SetLimit(int neuLimit)
    {
        limit = neuLimit;
    }

    public void Withdraw(int abheben)
    {
        bool check = this.guthaben + limit > abheben;
        if (!check)
        {
            this.guthaben -= 0;
            Console.WriteLine($"Sie habe {this.guthaben} Euro auf Ihrem Konto!");
        }
        else
        {

            this.guthaben -= abheben;
        }

    }

    public void Deposit(int einzahlen)
    {
        this.guthaben += einzahlen;
    }

    public override string ToString()
    {
        return $"Kontonummer: {kontonummer}\nKontoinhaber: {kontoinhaber}\nGuthaben: {guthaben} Euro\n";
    }

    static void Main(string[] args)
    {

        // Test

        Account a1 = new Account(1234567890, "san");

        Console.WriteLine(a1);

        a1.Deposit(1000);
        Console.WriteLine(a1);

        a1.Withdraw(990);
        Console.WriteLine(a1);

        a1.Withdraw(30);
        Console.WriteLine(a1);

        a1.Deposit(200);
        Console.WriteLine(a1);

        a1.Withdraw(500);

        SetLimit(500);
        a1.Withdraw(500);
        Console.WriteLine(a1);


    }
}




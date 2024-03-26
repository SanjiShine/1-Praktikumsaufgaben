using System.Xml.Linq;

namespace Klassen01;

enum Lebensmittelgruppe {Obst = 1, Gemüse, Fleisch, Süßwaren}

class Artikel
{
    string artikelbezeichnung;
    int artikelnummer;
    double verkauftspreis;
    Lebensmittelgruppe gruppe;

    public Artikel()
    {
        Console.Write("Geben Sie bitte die Artikelbezeichnung ein: ");
        artikelbezeichnung = Console.ReadLine();

        Console.Write("Geben Sie bitte die Artikelnummer ein:");

        artikelnummer = int.Parse(Console.ReadLine());

        Console.Write("Geben Sie bitte den Verkauftspreis ein:");

        verkauftspreis = double.Parse(Console.ReadLine());

        Console.Write("Geben Sie bitte die Lebensmittelgruppe ein:"); //  1 bis 4
        gruppe = (Lebensmittelgruppe)int.Parse(Console.ReadLine());
       
    }

    public Artikel(string artikelbezeichnung, int artikelnummer, double verkauftspreis, Lebensmittelgruppe gruppe = Lebensmittelgruppe.Süßwaren)
    {
        this.artikelbezeichnung = artikelbezeichnung;
        this.artikelnummer = artikelnummer;
        this.verkauftspreis = verkauftspreis;
        this.gruppe = gruppe;

    }

    public override string ToString()
    {
        return $"{artikelbezeichnung}: {artikelnummer}, {verkauftspreis}({gruppe})";
    }

    // Set-Medthoden
    public void SetPreis(double neuPreis)
    {
        this.verkauftspreis = neuPreis;
    }
    public void SetBez(string neuBez)
    {
        this.artikelbezeichnung = neuBez;
    }
    public void SetNummer(int neuNum)
    {
        this.artikelnummer = neuNum;
    }

    // Get-Medthoden
    public string GetBez()
    {
        return this.artikelbezeichnung;
    }

    public double GetPreis()
    {
        return this.verkauftspreis;
    }


    // Suche Medthode
    public static Artikel? Suche(Artikel[] artikels, string artikelBz)
    {
        for (int i = 0; i < artikels.Length; i++)
        {
            if (artikels[i].artikelbezeichnung == artikelBz) 
                return artikels[i];
        }
        return null;
    }

    // Suche den Teuersten Artikel Medthode
    public static Artikel Teuerste(Artikel[] artikels)
    {
        Artikel teuerste = artikels[0];
        double maxPreis = 0;
        
        for (int i = 0; i < artikels.Length; i++)
        {
            
            Artikel aktuellerArtikel = artikels[i];
            if (maxPreis < aktuellerArtikel.verkauftspreis)
            {
                teuerste = aktuellerArtikel;
            }
        }

        return teuerste;
    }

    static void Main(string[] args)
    {

        Artikel[] artikels = new Artikel[4];
        Console.WriteLine("Bitte 3 Artikel einpflgen");

        for(int i = 0; i < 3; i++)
        {
            artikels[i] = new Artikel();
            Console.WriteLine();
        }


        artikels[3] = new Artikel("Bounty", 4714, 2.19);

        int userAuswahl;

        do
        {
            Console.WriteLine("Was wünschen Sie zu tun?");
            Console.WriteLine("1 = Ändern");
            Console.WriteLine("2 = Ausgabe");
            Console.WriteLine("3 = teuerster Artikel");
            Console.WriteLine("4 = Ende");

            userAuswahl = int.Parse(Console.ReadLine());

            Console.WriteLine($"Ihre Auswahl: {userAuswahl}");

            if (userAuswahl == 1)
            {
                Console.Write("Bezeichnung des Artikels eingeben: ");
                string artikelBz = Console.ReadLine();

                Artikel gesuchteArtikel = Suche(artikels, artikelBz);

                if (gesuchteArtikel != null)
                {
                    Console.Write("Neue Bezeichnung: ");
                    string neuArtikelBz = Console.ReadLine();

                    gesuchteArtikel.SetBez(neuArtikelBz);

                    Console.Write("Neue Preis: ");
                    double neuPreis = double.Parse(Console.ReadLine());

                    gesuchteArtikel.SetPreis(neuPreis);

                }
                else
                {
                    Console.WriteLine("Den Artikel wurde nicht gefunden!");
                    Console.WriteLine();
                }

            }
            else if (userAuswahl == 2) //gibt alle Artikel aus
            {
                foreach( Artikel artikel in artikels)
                {
                    Console.WriteLine(artikel);
                }
                Console.WriteLine();
            }
            else if (userAuswahl == 3) //gibt die Artikelbezeichnung des teuester Artikel aus
            {
                Artikel teueste = Teuerste(artikels);
                Console.WriteLine($"Teuerster Artikel: {teueste.artikelbezeichnung}");
                Console.WriteLine();
            }
      
            else
            {
                Console.WriteLine("Falsche Eingabe, bitte versuchen Sie noch einmal.");
                Console.WriteLine();
            }
        }

        while (userAuswahl != 4); 

        Console.WriteLine("Ende das Program!");

    }
}


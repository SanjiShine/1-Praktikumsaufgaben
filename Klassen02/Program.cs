namespace Klassen02;

class Personalausweis
{
    int id;
    static int idLastest = 999;
    string name;


    public Personalausweis(string name)
    {
        this.name = name;
        this.id = ++idLastest;
    }

    public int GetId()
    {
        return this.id;
    }

    public string GetName()
    {
        return this.name;
    }


    static public int GetLastestId()
    {
         return idLastest;
    }

    public override string ToString()
    {
        return $"{id}: {name}";
    }


    static void Main(string[] args)
    {
        Personalausweis p1 = new Personalausweis("Cero");
        Personalausweis p2 = new Personalausweis("Uno");
        Personalausweis p3 = new Personalausweis("Dos");

        Personalausweis[] personalausweis = { p1, p2, p3 };

        foreach(Personalausweis p in personalausweis)
        {
            Console.WriteLine(p);
        }
    }


}


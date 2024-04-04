namespace Klassen09;

enum Geschlecht  {MAENLICH, WEIBLICH};

class Student
{
    int matrikelnummer;
    int geburtjahr;
    string name;

    string fach;
    static int anzahl;
    Geschlecht geschlecht;


    public Student (string name)
    {
        this.name = name;
        Student.anzahl++;
    }

    public Student(string name, int geburtjahr = -1)
    {
        this.name = name;
        this.geburtjahr = geburtjahr;
        Student.anzahl++;
    }

    public Student(string name, int geburtjahr = -1, int matrikelnummer = -1) 
    {
        this.name = name;
        this.geburtjahr = geburtjahr;
        this.matrikelnummer = matrikelnummer;
        Student.anzahl++;
    }

    public Student(string name, string fach, int geburtjahr, int matrikelnummer) : this(name, geburtjahr, matrikelnummer)
    {
        this.fach = fach;
    }

    public void Studieren()
    {
        Console.WriteLine($"{this.name} studiert gerade.");
        
    }

    public void Schlafen()
    {
        Console.WriteLine($"{this.name}  schläft gerade.");

    }

    public void Essen()
    {
        Console.WriteLine($"{this.name}  isst gerade.");

    }

    public static int GetAnzahl()
    {
        return Student.anzahl;
    }

    public void SetGeschlecht(Geschlecht geschlecht)
    {
        this.geschlecht = geschlecht;
    }

    public Geschlecht GetGeschlecht()
    {
        return this.geschlecht;
    }


    public bool IsValid()
    {
        int zahl = this.matrikelnummer;

        if (zahl == 0)
            return false; 

        int quersumme = 0;

        do
        {
            int ziffer = zahl % 10;

            quersumme += ziffer;

            zahl /= 10;

        } while (zahl > 0);

        

        if ( quersumme % 2 == 0)
        {
            return true;
        }
        return false;

    }


    public override string ToString()
    {
        return $"{this.matrikelnummer}: {this.name}({this.geburtjahr}): {this.fach}: {this.geschlecht}";
    }


}
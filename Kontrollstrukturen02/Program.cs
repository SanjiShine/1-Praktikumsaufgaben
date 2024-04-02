namespace Kontrollstrukturen02;

class Program
{

    static void ZeicheDreieck(int zahl, string zeichen)
    {
        for(int i = 0; i  < zahl; i++)
        {
            for (int j = 0; j <= i && j < zahl; j++)
            {
                Console.Write(zeichen);
            }

            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        ZeicheDreieck(8, "* ");
        
    }
}


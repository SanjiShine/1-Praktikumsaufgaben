namespace Kontrollstrukturen02;

class Program
{

    static void ZeicheDreieck(int zahl, string zeichen = "*", bool centered = false)
    {
        if (!centered)
        {
            for (int i = 0; i < zahl; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(zeichen);
                }

                Console.WriteLine();
            }
        }
        else
        {
            for (int i = 0, leerzeichen = zahl-1;  i < zahl; i++, leerzeichen--)
            {

                for (int j = 0; j < leerzeichen; j++)
                    Console.Write(' ');


                for (int j = 0; j < 2*i-1; j++)
                {  
                    Console.Write(zeichen);
                }

                Console.WriteLine();
            }
        }
    }



    static void Main(string[] args)
    {
        ZeicheDreieck(8);
        Console.WriteLine();
        ZeicheDreieck(10, "#", true);
        
    }
}


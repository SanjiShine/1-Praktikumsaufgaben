namespace Arrays12;

class Program
{

    public static int SamePositionSameNumber(int[] a, int[] b)
    {
        int samenumber = 0;
        int checkLength = a.Length;
        if (b.Length < a.Length)
        {

            checkLength = b.Length;
        }

        for (int i = 0; i < checkLength; i++)
        {
            if (a[i] == b[i])
            {
                samenumber++;
            }
        }

        return samenumber;
    }

    static void Main(string[] args)
    {
        int[] a = { 2, 3, 4, 5, 6, 7 };
        int[] b = { 1, 3, 4, 7, 9 };

        Console.WriteLine(SamePositionSameNumber(a,b));

    }
}


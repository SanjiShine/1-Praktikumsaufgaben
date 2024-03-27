namespace Arrays02;

class Program
{
    static int[] Summen(int[,] array)
    {
        int[] summe = new int[array.GetLength(0)];

        for(int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;

            for(int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }

            summe[i] = sum;
        }

        return summe; 
        
    }


    static void Main(string[] args)
    {

        int[,] a1 = { { 3, 5, 7, 1 }, { 0, 2, 9, 9 }, { 1, 1, 3, 5 } };

        Console.WriteLine("2D-Array: ");
        Console.WriteLine();

        for (int i = 0; i < a1.GetLength(0); i++)
        {
            for (int j = 0; j < a1.GetLength(1); j++)
            {
                Console.Write("{0,4}", a1[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        int[] sum = Summen(a1);

        Console.Write("Ergebnis: ");

        foreach(int i in sum)
        {
            Console.Write("{0,4}", i);
        }
    }
}


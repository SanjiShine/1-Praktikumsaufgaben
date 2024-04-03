namespace Arrays09;

class Program
{
    public static bool IsMarkovMatrix(double[,] m)
    {
        double[] sumColumn = new double[m.GetLength(0)];
        int count = 0;

        for(int i = 0; i < m.GetLength(0); i++)
        {
            for(int j = 0; j < m.GetLength(1); j++)
            {                
                    sumColumn[j] += m[i, j];
            }
        }

        for (int i = 0; i < sumColumn.Length; i++)
        {
            if (sumColumn[i] == 1)
            {
                count++;
            }
        }

        if(count == sumColumn.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main(string[] args)
    {
        double[,] matrix1 = { { 1, 0, 0 }, { 0, 1, 0.8 }, { 0, 0,0.1 } };

        for(int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                Console.Write("{0,5}", matrix1[i,j]);
            }

            Console.WriteLine();
        }

        Console.WriteLine(); // Zeileumbruck

        if (IsMarkovMatrix(matrix1))
        {
            Console.WriteLine("Das ist eine Markov-Matrix");
        }
        else
        {
            Console.WriteLine("Das ist keine Markov-Matrix");
        }
    }
}


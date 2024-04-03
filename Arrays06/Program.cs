namespace Arrays06;

class Program
{
    public static double SumColumn(double[,] m, int columnIndex)
    {
        double sumColumn = 0;

        for(int i = 0; i < m.GetLength(0); i++)
        {
              sumColumn += m[i, columnIndex];        
        }
        return sumColumn;

    }
    static void Main(string[] args)
    {
        double[,] matrix1 = { { 1, 2, 3 }, { 2, 3, 4 }, { 4, 5, 6 } };

        Console.WriteLine(SumColumn(matrix1, 0)); // Column 1
        Console.WriteLine(SumColumn(matrix1, 1)); // Column 2

    }
}


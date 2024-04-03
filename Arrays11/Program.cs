namespace Arrays11;

class Program
{
    public static void RotateValues(int[] values, int rotate)
    {
        int[] result = new int[values.Length];

        for (int i = 0; i < values.Length; i++)
        {
            if (rotate+i < values.Length)
            {
                result[rotate + i] = values[i];

            }

            Console.Write(result[i] + " ");
        }
    }

    static void Main(string[] args)
    {
        int[] array1 = { 1, 2, 3, 4, 5 };

        RotateValues(array1, 2);
    }
}


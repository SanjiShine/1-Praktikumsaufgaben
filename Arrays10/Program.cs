namespace Arrays10;

class Program
{
    public static void Merge(int[] arr1, int[] arr2)
    {
        int[] mergeArray = new int[arr1.Length + arr2.Length];

        for(int i = 0; i < arr1.Length; i++)
        {
           mergeArray[i] = arr1[i];
        }

        for(int j = 0; j < arr2.Length; j++)
        {
           mergeArray[arr1.Length + j] = arr2[j];
        }

        foreach(int k in mergeArray)
        {
            Console.Write(k + " ");
        }
    }

    static void Main(string[] args)
    {
        int[] a = { 2, 3, 4, 5, 6, 7 };
        int[] b = { 1, 3, 5, 7, 9, 11, 13 };

        Merge(a,b);
    }
}


namespace Klassen05;

class MyInteger
{
    int value;

    public MyInteger(int value)
    {
        this.value = value; 
    }

    public int GetValue()
    {
        return this.value;
    }

    public bool IsEven()
    {
       return this.value % 2 == 0;
        
    }

    public bool IsOdd()
    {
       return this.value % 2 == 1;
    }

    public bool IsPrime()
    {
        if(this.value == 2 || this.value == 3 )
        {
            return true;

        }else if(this.value%2 != 0)
        {
            for(int i = 4; i < this.value; i++)
            {
                if(this.value % i != 0)
                {
                    return true;
                }
            }
        }

        return false;
    }

    // Static Method
    static public bool IsEven(int number)
    {
        return number % 2 == 0;

    }

    static public bool IsOdd(int number)
    {
        return number % 2 == 1;
    }

    static public bool IsPrime(int number)
    {
        if (number == 2 || number == 3)
        {
            return true;

        }
        else if (number % 2 != 0)
        {
            for (int i = 4; i < number; i++)
            {
                if (number % i != 0)
                {
                    return true;
                }
            }
        }

        return false;
    }


    // Static Method mit Objekte als Agrumente
    static public bool IsEven(MyInteger myInteger)
    {
        return myInteger.GetValue() % 2 == 0;

    }

    static public bool IsOdd(MyInteger myInteger)
    {
        return myInteger.GetValue() % 2 == 1;
    }

    static public bool IsPrime(MyInteger myInteger)
    {
        int number = myInteger.GetValue();
        if (number == 2 || number == 3)
        {
            return true;

        }
        else if (number % 2 != 0)
        {
            for (int i = 4; i < number; i++)
            {
                if (number % i != 0)
                {
                    return true;
                }
            }
        }

        return false;
    }

    // Vergleiche den angegebenen int-Wert mit dem Wert im Objekt
    public bool Equals(int number)
    {
        if (number == this.value)
        {
            return true;
        }
        else
        {           
            return false;
        }
    }

    // Vergleiche den Wert vom angegebenen Objekt mit dem Wert in einem anderen Objekt
    public bool Eqauls(MyInteger number)
    {
        if (number.GetValue() == this.GetValue())
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    static public int ParseInt(char[] number)
    {

        return int.Parse(number);

        //for(int i = 0; i < number.Length; i++)
        //{
            
        //}
    }

    static public int ParseInt(string number)
    {
        return int.Parse(number);
    }




    static void Main(string[] args)
    {
        Console.WriteLine(IsEven(30));
        Console.WriteLine(IsOdd(30));
        Console.WriteLine(IsPrime(23));

        MyInteger integer1 = new MyInteger(201);

        MyInteger integer2 = new MyInteger(201);

        Console.WriteLine(integer2.Equals(201));
        Console.WriteLine(integer1.Eqauls(integer2));

        Console.WriteLine(integer1.IsPrime());
        Console.WriteLine(integer2.IsEven());

        Console.WriteLine(IsEven(integer2));

        Console.WriteLine(ParseInt("1235"));

        char[] a = { '2', '3','4','5' };

        Console.WriteLine(ParseInt(a));
    }
}


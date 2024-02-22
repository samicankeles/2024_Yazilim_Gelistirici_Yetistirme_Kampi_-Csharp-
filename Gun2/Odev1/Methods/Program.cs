namespace Methods;

class Program
{
    static void Main(string[] args)
    {
        //AddMethods();

        Console.WriteLine(Multipy(2,4));
        Console.WriteLine(Multipy(2,4,5));
        Console.WriteLine(Add6(1,2,3,4,5,6,7,8,9,0,2,4,6,8,999,123456));
        Console.WriteLine(AddAndMultipy(10,1,2,3));

        Console.ReadLine();
    }

    private static void AddMethods()
    {
        Add();

        var result = Add(23, 38);
        Console.WriteLine("result = " + result);

        var result2 = Add2(23);
        Console.WriteLine("result2 = " + result2);

        int number1 = 25;
        int number2 = 47;
        int number3;
        var result3 = Add3(number1, number2);
        Console.WriteLine("result3 = " + result3);
        Console.WriteLine("number1 = " + number1);
        var result4 = Add4(ref number1, number2);
        Console.WriteLine("result4 = " + result4);
        Console.WriteLine("number1 = " + number1);
        Console.WriteLine("number2 = " + number2);
        var result5 = Add5(out number2, out number3);
        Console.WriteLine("result5 = " + result5);
        Console.WriteLine("number1 = " + number1);
        Console.WriteLine("number2 = " + number2);
        Console.WriteLine("number3 = " + number3);
    }

    static void Add()
    {
        Console.WriteLine("Added !!!");
    }

    static int Add(int number1, int number2)
    {
        var result = number1 + number2;
        return result;
    }

    static int Add2(int number1, int number2=30)
    {
        var result = number1 + number2;
        return result;
    }

    static int Add3(int number1, int number2)
    {
        number1 = 10;
        var result = number1 + number2;
        return result;
    }

    static int Add4(ref int number1, int number2)
    {
        number1 = 10;
        var result = number1 + number2;
        return result;
    }

    static int Add5(out int number1,out int number2)
    {
        number1 = 9;
        number2 = 11;
        var result = number1 + number2;
        return result;
    }

    static int Multipy(int number1 = 20, int number2 = 30)
    {
        var result = number1 * number2;
        return result;
    }

    static int Multipy(int number1 = 20, int number2 = 30, int number3 = 40)
    {
        var result = number1 * number2 * number3;
        return result;
    }

    static int Add6(params int[] numbers)
    {
        return numbers.Sum();
    }

    static int AddAndMultipy(int number, params int[] numbers)
    {
        return number * numbers.Sum();
    }
}


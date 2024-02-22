namespace Loops;

class Program
{
    static void Main(string[] args)
    {
        //ForLoop();
        //WhileLoop();
        //DoWhileLoop();
        //ForeachLoop();

        int number = 7;
        bool isPrimeNumber = IsPrimeNumber(number);
        if (isPrimeNumber)
        {
            Console.WriteLine("Number is prime");
        }
        else
        {
            Console.WriteLine("Number is not prime");
        }

        Console.ReadLine();
    }

    private static bool IsPrimeNumber(int number)
    {
        bool result = true;
        for (int i = 2; i < number; i++)
        {
            if (number%i==0)
            {
                result = false;
                i = number;
            }
        }
        return result;
    }

    private static void ForeachLoop()
    {
        string[] students = new string[] { "Ali", "Ahmet", "Mehmet" };
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    private static void DoWhileLoop()
    {
        int number = 10;
        do
        {
            Console.WriteLine(number);
            number--;
        } while (number > 0);
        Console.WriteLine(" * * * ");
        number = 10;
        do
        {
            Console.WriteLine(number);
            number--;
        } while (number == 12);
    }

    private static void WhileLoop()
    {
        int number = 100;
        while (number >= -23)
        {
            Console.WriteLine(number);
            number--;
        }
        Console.WriteLine("Now number is {0}", number);
    }

    private static void ForLoop()
    {
        for (int i = 1; i < 101; i += 2)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Finished !");
    }
}


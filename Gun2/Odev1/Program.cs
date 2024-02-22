namespace TypesAndVariables;

class Program
{
    static void Main(string[] args)
    {
        //Value Types
        char character = 'A';
        bool condition = true; //bool = true or false
        byte number0 = 3; //8bit
        //limits 0<byte<255
        short number1 = 5; //16bit
        //limits -32768 < short < 32767
        int number2 = 10; //32bit
        //limits -2147483648 < int < 2147483647
        long number3 = 100; //64bit
        //limits -9223372036854775808 < long < 9223372036854775807
        double number4 = 10.4;
        decimal number5 = 10.4M;
        var number8 = 22;
        var name = "John";

        Console.WriteLine(Days.Friday);
        Console.WriteLine((int)Days.Wednesday);
        Console.ReadLine();
    }
}

enum Days
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}
enum Days2
{
    Monday=10, Tuesday, Wednesday, Thursday=237, Friday, Saturday, Sunday
}


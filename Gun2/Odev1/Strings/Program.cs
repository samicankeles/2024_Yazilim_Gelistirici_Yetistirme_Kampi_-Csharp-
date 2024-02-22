namespace Strings;

class Program
{
    static void Main(string[] args)
    {
        //Intro();

        string sentence = "My name is Sami Can Keles";
        var result = sentence.Length;
        Console.WriteLine(result);
        var result2 = sentence.Clone();
        sentence = "My name is Sami";
        Console.WriteLine(result2);
        bool result3 = sentence.EndsWith("i");
        bool result4 = sentence.StartsWith("My n");
        Console.WriteLine(result3);
        Console.WriteLine(result4);
        var result5 = sentence.IndexOf("name");
        var result6 = sentence.IndexOf("my");
        var result7 = sentence.IndexOf(" ");
        var result8 = sentence.LastIndexOf(" ");
        Console.WriteLine(result5);
        Console.WriteLine(result6);
        Console.WriteLine(result7);
        Console.WriteLine(result8);
        string result9 = sentence.Insert(0, "Hello, ");
        Console.WriteLine(result9);
        string result10 = sentence.Substring(3 );
        string result11 = sentence.Substring(3, 4);
        Console.WriteLine(result10);
        Console.WriteLine(result11);
        string result12 = sentence.ToLower();
        string result13 = sentence.ToUpper();
        Console.WriteLine(result12);
        Console.WriteLine(result13);
        string result14 = sentence.Replace(" ", "_");
        Console.WriteLine(result14);
        string result15 = sentence.Remove(2);
        string result16 = sentence.Remove(2, 5);
        Console.WriteLine(result15);
        Console.WriteLine(result16);



        Console.ReadLine();
    }

    private static void Intro()
    {
        string city = "Ankara";
        Console.WriteLine(city[1]);
        Console.WriteLine(" * * * ");

        foreach (var item in city)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(" * * * ");

        string city2 = "İstanbul";
        string result = city + " " + city2;
        Console.WriteLine(result);
        Console.WriteLine(" * * * ");

        Console.WriteLine("{0} {1}", city, city2);
        Console.WriteLine(" * * * ");
    }
}


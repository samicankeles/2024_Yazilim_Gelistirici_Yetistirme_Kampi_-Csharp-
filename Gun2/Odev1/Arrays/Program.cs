namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        string[] students = new string[3];
        students[0] = "Ali";
        students[1] = "Ahmet";
        students[2] = "Metmet";

        string[] students2 = new string[] {"Ali", "Ahmet", "Mehmet"};

        string[] students3 = { "Ali", "Ahmet", "Mehmet" };

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        string[,] regions = new string[7, 3]
        {
            {"İstanbul","Kocaeli","Bursa"},
            {"Ankara","Kayseri","Konya "},
            {"Antalya","Adana","Mersin"},
            {"Rize","Trabzon","Samsun"},
            {"İzmir","Muğla","Manisa"},
            {"Gaziantep","Hatay","Şanlıurfa"},
            {"Hakkari","Muş","Erzurum"},
        };

        for (int i = 0; i <= regions.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= regions.GetUpperBound(1); j++)
            {
                Console.WriteLine(regions[i,j]);
            }
            Console.WriteLine(" * * * * * * ");
        }

        Console.ReadLine();
    }
}


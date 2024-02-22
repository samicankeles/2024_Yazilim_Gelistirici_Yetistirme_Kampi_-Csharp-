namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        //Intro();

        //Demo();

        ICustomerDal[] customerDals = new ICustomerDal[]
        {
            new SqlServerCustomerDal(),
            new OracleCustomerDal(),
            new MySqlCustomerDal()
        };
        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }

        Console.ReadLine();
    }

    private static void Demo()
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new SqlServerCustomerDal());
        customerManager.Add(new OracleCustomerDal());
    }

    private static void Intro()
    {
        Customer customer = new Customer
        {
            Id = 1,
            FirstName = "Sami Can",
            LastName = "Keleş",
            Adress = "Sakarya"
        };

        Student student = new Student
        {
            Id = 1,
            FirstName = "Ali",
            LastName = "Veli",
            Departmant = "Computer Sciences"
        };

        PersonManager manager = new PersonManager();
        manager.Add(customer);
        manager.Add(student);
    }
}

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}
class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Adress { get; set; }
}
class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Departmant { get; set; }
}
class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName + " Added !");
    }
}

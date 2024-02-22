namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person[]
        {
            new Customer{FirstName = "Ali"},
            new Student{FirstName = "Veli"},
            new Person{FirstName = "Mehmet"}
        };
        foreach (var person in people)
        {
            Console.WriteLine(person.FirstName);
        }

        Console.ReadLine();
    }
}

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
class Customer : Person
{
    public string City { get; set; }
}
class Student : Person
{
    public string Department { get; set; }
}

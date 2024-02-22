namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int, decimal, float, enum, boolean - value types
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1  = sayi2;
            sayi2 = 100;
            Console.WriteLine(sayi1);


            // array, class, interface ... reference types
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] {10,20,30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine(sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FistName = "Sami";
            person2 = person1;
            person1.FistName = "Can";
            Console.WriteLine(person2.FistName);
            Customer customer = new Customer();
            customer.FistName = "Temel";
            customer.LastName = "Keleş";
            customer.CreditCardNumber = 123456789;
            Employee employee = new Employee();
            employee.FistName = "Erol";
            Person person3 = customer;
            Console.WriteLine(person3.LastName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);
            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            personManager.Add(employee);
            personManager.Add(person1);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
    }
    // base class : Person
    class Customer:Person
    {
        public int CreditCardNumber { get; set; }
    }
    // base class : Person
    class Employee :Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FistName);
        }
    }
}
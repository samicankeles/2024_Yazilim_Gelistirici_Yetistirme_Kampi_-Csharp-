namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer{Id = 1, FirstName = "Sami", LastName = "Keleş", City = "Sakarya"};
            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Temel";
            customer2.LastName = "Ay";
            customer2.City = "Samsun";
            Customer customer3 = new Customer(2, "Can", "Keleş", "Kocaeli");
        }
    }

    class Customer
    {
        // default constructor
        public Customer()
        {
            Console.WriteLine("Customer çalıştı");
        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Console.WriteLine("Customer çalıştı");
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
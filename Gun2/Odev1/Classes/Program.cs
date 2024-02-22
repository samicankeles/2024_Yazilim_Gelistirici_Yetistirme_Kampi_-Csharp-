namespace Classes;

class Program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.Update();

        ProductManager productManager = new ProductManager();
        productManager.Add();
        productManager.Update();

        Customer customer = new Customer();
        customer.City = "Sakarya";
        customer.FirstName = "Sami Can";
        customer.LastName = "Keleş";
        customer.Id = 1;

        Customer customer2 = new Customer { Id = 2, FirstName = "Ahmet", LastName = "Yılmaz", City = "Denizli" };
        Console.WriteLine(customer2.FirstName);

        Console.ReadLine();
    }
}

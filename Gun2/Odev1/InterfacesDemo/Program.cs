namespace InterfacesDemo;

class Program
{
    static void Main(string[] args)
    {
        IWorker[] workers = new IWorker[]
        {
            new Worker(), new Manager(), new Robot()
        };
        foreach (var worker in workers)
        {
            worker.Work();
        }

        IEat[] eats = new IEat[]
        {
            new Worker(), new Manager()
        };
        foreach (var eat in eats)
        {
            eat.Eat();
        }

        Console.ReadLine();
    }
}

interface IWorker
{
    void Work(); 
}
interface IEat
{
    void Eat();
}
interface ISalary
{
    void GetSalary();
}
class Manager : IWorker, IEat, ISalary
{
    public void Eat()
    {

    }

    public void GetSalary()
    {

    }

    public void Work()
    {

    }
}
class Worker : IWorker, IEat, ISalary
{
    public void Eat()
    {

    }

    public void GetSalary()
    {

    }

    public void Work()
    {

    }
}
class Robot : IWorker
{
    public void Work()
    {

    }
}


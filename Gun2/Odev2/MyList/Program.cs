using System.Globalization;

namespace MyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            List<string> addList = new List<string>{"v1", "v2", "v3", "v4", "v5", "v6"};
            for (int i = 0; i < addList.Count; i++)
            {
                myList.Add(addList[i]);
            }

            ShowArray<string>(myList.values);
            myList.Delete(1);
            ShowArray<string>(myList.values);
            myList.Update(3,"v05");
            ShowArray<string>(myList.values);

            Console.ReadLine();
        }
        static void ShowArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
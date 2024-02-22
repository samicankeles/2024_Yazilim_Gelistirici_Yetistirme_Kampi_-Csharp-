namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);
            

            TestList<string> sehirler2 = new TestList<string>();
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            Console.WriteLine(sehirler2.Count);

        }
    }

    class TestList<T>
    {
        private T[] _array;
        private T[] _tenparray;

        public TestList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _tenparray = _array;
            _array = new T[_tenparray.Length+1];
            for (int i = 0; i < _tenparray.Length; i++)
            {
                _array[i] = _tenparray[i];
            }
            _array[_array.Length-1]= item;
        }

        public int Count
        {
            get { return _array.Length; }
        }
    }
}
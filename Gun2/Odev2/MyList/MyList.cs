using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class MyList<T>
    {   
        public T[] values;
        private T[] _valuesReserve;
        public MyList()
        {
            values = new T[0];
        }
        public void Add(T value)
        {
            if (!(values.Length==0))
            {
                _valuesReserve = new T[values.Length+1];
                for (int i = 0; i < values.Length; i++)
                {
                    _valuesReserve[i] = values[i];
                }
                _valuesReserve[values.Length] = value;
                SyncValueToValuesReserve();
            }
            else
            {
                values = new T[1];
                values[0] = value;
            }
        }
        public void Delete(int indexNo)
        {
            if (indexNo < values.Length)
            {
                _valuesReserve = new T[values.Length - 1];
                for (int i = 0; i < _valuesReserve.Length; i++)
                {
                    if (i < indexNo)
                    {
                        _valuesReserve[i] = values[i];
                    }
                    else
                    {
                        _valuesReserve[i] = values[i+1];
                    }
                }
                SyncValueToValuesReserve();
            }
        }
        public void Update(int indexNo, T value)
        {
            values[indexNo] = value;
        }
        private void SyncValueToValuesReserve()
        {
            values = new T[_valuesReserve.Length];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = _valuesReserve[i];
            }
        }
    }
}

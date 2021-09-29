using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<T, K>
    {
        T[] _key;
        K[] _value;


        T[] _tempKey;
        K[] _tempValue;


        public MyDictionary()
        {
            _key = new T[0];
            _value = new K[0];
        }
 
        public void Add(T key, K value)
        {
            _key = _tempKey;
            _value = _tempValue;

            _key = new T[_key.Length + 1];
            _value = new K[_value.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
                _value[i] = _tempValue[i];
            }
            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;




        }




    }
}

using System;
using System.Collections.Generic;
using System.Text;


namespace KampGun4Odev5
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TKey[] tempKeys;
        TValue[] values;
        TValue[] tempValues;

        public MyDictionary()
        {
            keys = new TKey[0];
            tempKeys = new TKey[0];
            values = new TValue[0];
            tempValues = new TValue[0];

        }

        public void Add(TKey key, TValue value)
        {
            //array yerine list kullanarak bu bölüm iki satıra indirilebiliyor! Tüm method
            tempKeys = keys;
            keys = new TKey[keys.Length + 1];
            tempValues = values;
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];                              
                values[i] = tempValues[i];               

            }
            
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

            Console.WriteLine(value + " myDictionary eklendi.");

        }

        //public TValue GetValue(TKey key)
        //{
        //    int index = Array.IndexOf(keys, key);
        //    TValue value = values[index];
        //    return value;
        //}

        public TValue this[TKey key]
        {
            get 
            {
                int index = Array.IndexOf(keys, key);
                TValue value = values[index];
                return value;
            }
            
        }
    }
}





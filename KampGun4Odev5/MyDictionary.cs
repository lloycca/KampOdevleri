using System;
using System.Collections.Generic;
using System.Text;


namespace KampGun4Odev5
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TKey[] tempKeys;
        TValue[,] values;
        TValue[,] tempValues;

        public MyDictionary()
        {
            keys = new TKey[0];
            tempKeys = new TKey[0];
            values = new TValue[0, 0];
            tempValues = new TValue[0, 0];

        }

        public void Add(TKey key, TValue value)
        {
            tempKeys = keys;
            keys = new TKey[keys.Length + 1];
            tempValues = values;
            values = new TValue[values.Length + 1, values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                for (int j = 0; j < tempKeys.Length; j++)
                {
                    values[i, j] = tempValues[i, j];
                }

            }

            keys[keys.Length - 1] = key;
            values[keys.Length - 1, keys.Length - 1] = value;

            Console.WriteLine(value + " myDictionary eklendi.");

        }
    }
}





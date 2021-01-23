using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryOdev
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keyArray;
        TValue[] valueArray;

        public MyDictionary()
        {
            keyArray = new TKey[0];
            valueArray = new TValue[0];
        }

        public void Add(TKey itemKey, TValue itemValue)
        {

            TKey[] tempKeyArray = keyArray;
            TValue[] tempValueArray = valueArray;

            keyArray = new TKey[keyArray.Length + 1];
            valueArray = new TValue[valueArray.Length + 1];

            for (int i = 0; i < tempValueArray.Length; i++)
            {
                keyArray[i] = tempKeyArray[i];
                valueArray[i] = tempValueArray[i];
            }

            keyArray[keyArray.Length - 1] = itemKey;
            valueArray[valueArray.Length - 1] = itemValue;

        }
        public void printAll()
        {
            for (int i = 0; i < keyArray.Length; i++)
            {
                Console.WriteLine(keyArray[i] + " Key , Value : " + valueArray[i]);
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine();
            }
        }

        public TKey[] Items1
        {
            get { return keyArray; }
        }

        public TValue[] Items2
        {
            get { return valueArray; }
        }

        public void Count()
        { 
        
        }
        //public void Cantains()
        //{
        //    get { return }

        //}
    }
}

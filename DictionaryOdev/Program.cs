using System;
using System.Collections;
using System.Collections.Generic;

namespace DictionaryOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            //IDictionary<int, string> musteriler = new Dictionary<int, string>();
            //musteriler.Add(2,"gercek1");
            //musteriler.Add(4, "gercek2");
            //musteriler.Add(12, "tuzel1");
            //musteriler.Add(14, "tuzel2");


            //foreach (KeyValuePair<int, string> musteri in musteriler)
            //{
            //    Console.WriteLine("{0}, {1}", musteri.Key, musteri.Value );
            //}

            MyDictionary<string, string> idOgrenci = new MyDictionary<string, string>();

            idOgrenci.Add("125", "Ayşe");
            idOgrenci.Add("390","Gökhan");


            idOgrenci.printAll();

            for (int i = 0; i < idOgrenci.Count; i++) // bununla ilgili metodu eklemeyi öğrenmem lazım.
            {
            Console.WriteLine(idOgrenci.Items1[0], idOgrenci.Items2[0]);
            }

        }


    }
}

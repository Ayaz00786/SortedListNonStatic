using System;
using System.Collections;

namespace SortedListNonStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
                SortedList list = new SortedList();

                //----------------Add Hashtable----------

                list.Add("Ayaz", "2234");
                list.Add("Vikash", "2294");
                list.Add("Arvind", "1253");
                list.Add("Anup", "4321");
                list.Add("Ashish", "1234");

                        //foreach (DictionaryEntry item in list)
                        //{
                        //    Console.WriteLine($" {item.Key} : {item.Value}");
                        //}

                //---------------print only key-------------

                        
                        Console.WriteLine("--------Print Only Key--------------");
                        var key = list.Keys;
                        foreach(var item in key)
                        {
                            Console.WriteLine(item);
                        }

                //---------------print only values-------------

                        Console.WriteLine("\n--------Print Only Values--------------");
                        var value = list.Values;
                        foreach (var item in value)
                        {
                            Console.WriteLine(item);
                        }
        }
    }
}

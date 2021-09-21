using System;
using System.Collections.Generic;

namespace Course08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Bob");
            list.Add("Alex");
            list.Insert(2, "Marco");
            
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Count list " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            string s2 = list.FindLast(x => x[0] == 'A');
            int pos1 = list.FindIndex(x => x[0] == 'A');

            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }             

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace _06泛型集合List与Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            #region List<T>集合

            //ArrayList arrayList = new ArrayList();
            ////arrayList.Add(

            //List<string> list = new List<string>();
            //list.Add("aaa");
            //list[

            //List<int> list1 = new List<int>();
            //list1.Add(111);

            //list1[

            //List<double> list1 = new List<double>();
            //list1.Add(9.9);
            //list1.Add(10);

            //list1.Sort();

            //list1.Average();
            //list1.Max();
            //list1.Min();

            //list1.Remove(9.9);
            //list1.RemoveAt(0);
            //list1.Count; list1.Capacity;


            //List<int> 

            //    List<string> 

            //List<Person> list = new List<Person>();
            //list.Add(new Person());

            //list.Sort(
            #endregion


            #region Dictionary<K,V>


            Dictionary<string, Person> dict = new Dictionary<string, Person>();

            dict.Add("ylp", new Person());

            dict.ContainsKey();
            dict.Remove();


            //dict["ylp"].Name


            //遍历键
            foreach (string key in dict.Keys)
            {

            }

            //遍历值

            foreach (Person value in dict.Values)
            {

            }

            //键值对一起遍历
            foreach (KeyValuePair<string, Person> kv in dict)
            {
                Console.WriteLine(kv.Key + "     " + kv.Value);
            }

            #endregion


        }
    }

    class Person
    {
        public string Name { get; set; }
    }
}

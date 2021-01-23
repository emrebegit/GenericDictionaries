using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyDictionary<T>
    {
        Dictionary<string,List<T>> d=new Dictionary<string,List<T>>();
        T[] items;
        public MyDictionary()
        {
            items = new T[0];
        }
        public void Add(string key,List<T> list)
        {
            d.Add(key, list);
        }
        public void DictPrinter()
        {
            foreach (KeyValuePair<string, List<T>> kvp in d)
            {
                Console.WriteLine("Key={0}, Value={1}", kvp.Key, kvp.Value[0]);
            }
        }
    }
}

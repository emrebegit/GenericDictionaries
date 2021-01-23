using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> isimler = new MyDictionary<string>();
            List<string> list=new List<string>();
            list.Add("05050");
            isimler.Add("Engin",list);

            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);
            isimler.DictPrinter();
            Console.ReadKey();
        }
    }
}

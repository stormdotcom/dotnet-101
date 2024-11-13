using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class CollectionsSample
    {
        // list 
        List<int> calender = new List<int> { 11, 12, 14, 14 };
        List<string> names = new List<string> { "A", "B", "C" };


        // dict
        Dictionary<string, string> details = new Dictionary<string, string>
        {
            {"name", "Ajmal" },
            {"age" , "1" },
            {"place", "tvm" }

        };

        public void IterateList()
        {
            foreach (int i in calender)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n String List");
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }
        }

        public void IterateDict()
        {
            foreach(var entry  in details)
            {   
                string key = entry.Key;
                string value = entry.Value;
                Console.WriteLine(key);
                Console.WriteLine(value);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Parent : IHuman
    {

        public string name { get; } = "Human";
        public int age {  get; set; }
        public void speak()
        {
            Console.WriteLine("Human Speaking");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal interface IHuman
    {
        string name { get; }
        int age { get; set; }
    }
}

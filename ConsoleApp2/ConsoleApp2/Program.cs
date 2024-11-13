using ConsoleApp2;
using System;

class Program
{
    static void MyMethod(string val)
    {
        int a = 1;
        string b = "AB";
        if (b[a].ToString() == val)
        {
            Console.WriteLine("is true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }

    // call

    static void Main(String[] args)
    {
        Child c = new Child();
        c.speak();
        //FileReadWrite frw = new FileReadWrite();
        CollectionsSample collectionsSample = new CollectionsSample();

        collectionsSample.IterateList();
        collectionsSample.IterateDict();

       
    }

}
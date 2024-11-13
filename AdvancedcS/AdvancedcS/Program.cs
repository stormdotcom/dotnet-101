using System;

namespace AdvancedcS
{
   
    public delegate void PrintMessage(string message);
    class Program
    {
        struct Person
        {
            public string name;
            public int marks;
        }
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
       
        static void Main(string[] args)
        {
            Person p1;
            p1.name = "AJN";
            p1.marks = 1;
            int[] numbers = { 1, 2, 3,4,5,6,7,8,22,12,14,55,556 };
            var evnNm = numbers.Where(n=> n%2 == 0);

            foreach(var n in evnNm) { Console.WriteLine(n); }
            PrintMessage p = new PrintMessage(DisplayMessage);
            p("This is delegate example");
        }
    }
}

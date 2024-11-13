using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class FileReadWrite
    {
        public void writeFile() {
            try
            {
                string txt = "hello world";
                File.WriteAllText("filename.txt", txt);
                Console.WriteLine($"File write successfully {txt}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error \n" + e.Message);
            }
        }

        public void readFile() {

            try
            {
                string txt = File.ReadAllText("filename.txt");
                Console.WriteLine("Read success \n");
                Console.WriteLine(txt);
            }
            catch (Exception e) {
                Console.WriteLine("Error Reading file \n" + e.Message);
            }
            
        }
        
    }
}

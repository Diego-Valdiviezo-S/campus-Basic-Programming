using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            try
            {
                class1.Fail();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString()); 
                Console.ReadKey();
            }
        }
    }
}

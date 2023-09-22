using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal static class Class1
        {
            public static void Test()
            {
                Console.WriteLine("Test1");
            }



            public static void Test(int a)
            {
                Console.WriteLine("Test2");
            }
        
            
            public static void Test(string a)
            {
                Console.WriteLine("Test3");
            }
        }
    
}

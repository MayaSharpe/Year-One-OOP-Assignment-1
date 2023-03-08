using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            //calls the testing class and runs the code_test method
            Testing tests = new Testing();
            tests.code_test();
            //ReadLine allows the console to stay open
            Console.ReadLine();

        }
    }
}

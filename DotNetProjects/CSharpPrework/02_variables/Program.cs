using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //1    //2   //3
            string firstName = "Paul";
            Console.WriteLine(firstName);

            //1    //2
            string lastName = "Johnson";

            int birthYear; //Not initialized
                           //3
            int birthYear = 1986;
            Console.WriteLine(birthYear);

            Console.ReadLine();
        }
    }
}

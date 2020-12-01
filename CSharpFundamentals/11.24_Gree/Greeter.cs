using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._24_Gree
{
    // Build a class called Greeter
    public class Greeter
    {
        //public enum Farewell { Adios, Bye, Later }
                                                            // Properties- Variable for the whole class
        public string Name { get; set; }
        public string Farewell { get; set; }

        // Empty Constructor for methods   
        public Greeter() { }

        // Build a method that takes in a name as a parameter and outputs (writes to console) hello to that person
        public Greeter(string name)
        {
            Name = name;
            Greeter numOne = new Greeter();
            numOne.Name = "Weston";

            Console.WriteLine("Hello " + numOne);
        }

        //public string Salutations(string name)
        //{

        //}

            // Parameters w/ same name as properties

    // Build a method that outputs (writes to the Console) Good Morning/Afternoon/Evening/Night depending on the time of day.
    }
}

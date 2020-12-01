using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges_Wk2
{
    // 1. Build a method that takes in a name as a parameter and then outputs (writes to the Console) hello to that person.
    // 2. Build another method that outputs (writes to the Console) some sort of farewell to the name it is given as a parameter.
    // 3. Build a method that outputs (writes to the Console) Good Morning/Afternoon/Evening/Night depending on the time of day.
    // 4. New up (instantiate) an instance of your Greeter class inside your Main method. From this instance call all of the methods you've built out.

    public class Greeter
    {
        public string firstName = "Jesus";
        public void Name(string firstName)
        {
            Console.WriteLine("Hello" + firstName);
        }    
    }
}

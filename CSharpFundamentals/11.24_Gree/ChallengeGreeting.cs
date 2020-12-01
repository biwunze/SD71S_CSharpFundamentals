using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _11._24_Gree
{
    [TestClass]
    public class ChallengeGreeting
    {
        // New up (instantiate) an instance of your Greeter class inside your Main method. From this instance call all of the methods you've built out.

        [TestMethod]
        public void TestMethod1()
        {

            // Method that outputs (writes to the Console) some sort of farewell to the name it is given as a parameter.
            Greeter numTwo = new Greeter
            {
                Name = "Breshard",
                Farewell = "Adios",
            };

        }
    }
}

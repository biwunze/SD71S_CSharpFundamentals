using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GreetChallenge
{
    [TestClass]
    public class Greeter
    {
        // 1. Build a method that takes in a name as a parameter and then outputs (writes to the Console) hello to that person.
        public void Greetings(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        [TestMethod]
        public void GreeterMethod(string[] args)
        {
            Greetings("Jesus");
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenges_Wk2
{
    [TestClass]
    public class UnitTest1      //Greeter
    {

        string name = "Jesus";
        [TestMethod]
        public void TestMethod1(string name)
        {
            Console.WriteLine("Hello" + name);

        }
    }
}

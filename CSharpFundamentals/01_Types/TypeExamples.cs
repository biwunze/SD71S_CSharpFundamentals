using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //-- Whole Numbers
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholeNumber = 16;     //--Int16
            int wholeNumber = 32;            //--Int32
            long largeWholeNumber = 64;      //--Int64

            //-- Decimnals
            float floatExample = 1.234567f;
            double doubleExample = 1.234563d;
            decimal decimalExample = 1.70000m;

            char letter = 'j';

            //--Operators
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;         //--17 / 5 = 3
            Console.WriteLine(quot);
            int remainder = numOne % numTwo;   //--modulus       17 % 5 = 2
            Console.WriteLine(remainder);

            Console.WriteLine("Hello");
        }

        [TestMethod]
        public void ReferencesTypes()
        {
            char space = ' ';
            //-- Strings= Words, lines of characters
            string stringExample = "This is a string.";
            string name = "Briggs";

            string declared;
            declared = "Now it's initialized.";

            // Formatting strings
            string concatenate = stringExample + space + name;  //Putting things together.
            string interpolate = $"{name}. Here is the string: {stringExample}";  // Takes whatever name is.

            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

            //-- Other Object Examples
            DateTime now = DateTime.Now;                        //Shows when the code runs.
            Console.WriteLine(now);
                                              //Constructor = Year, Month, Day
            DateTime randomDate = new DateTime(2019, 6, 29);

            TimeSpan waitTime = randomDate - now;
            Console.WriteLine(waitTime.TotalSeconds);


            //-- Collections
            //-- Arrays
            string anotherExampleString = "Hello World";
            string[] stringArray = { anotherExampleString, "Hello", "World", "!" }; //Array size of 4
            string[] students = new string[15];                                     //An array of 15 students

            Console.WriteLine(stringArray);

            //-- Lists
            List<string> listOfStrings = new List<string>();                      //ctrl + .
            listOfStrings.Add("Lawrence");

            //-- Queues
            Queue<string> firstInFirstOut = new Queue<string>();                //First one in is first out.
            firstInFirstOut.Enqueue("Luke");                                    //Add object to end of queue

            //-- Dictionaries
            //key   value type
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('j', "Josh");

            //-- Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();
        }
    }
}

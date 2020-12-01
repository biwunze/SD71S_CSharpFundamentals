using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isTrue = 17 > 5;                           // These 2 are assignments
            bool isFalse = 17 == 4;                         // "Boolean statement"
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool isTrue = true;
            if (isTrue)
            {
                // Do something here
            }

            int age = 24;

            if (age > 17)
            {
                Console.WriteLine("You're an adult");
            }
            /*else
            {
                Console.WriteLine("You're still a kid");
            }*/

            else if (age > 6)                             //Are you greater than 17, else check if you're greater than 6. 5 wouldn't be true for either.
            {
                Console.WriteLine("You're a kid");
            }                                                       
            else if (age > 0)
            {
                Console.WriteLine("You're far too young to be on a computer");
            }
            else                                            //Catch all
            {
                Console.WriteLine("You're not even born yet");
            }


            
            if (age > 65 && age < 18)
            {
                // "And" comparison &&
            }

            if (age <= 65 || age >=18)
            {
                // "Or" comparison ||
            }

            if (age == 17)
            {
                // Is "equal to"
            }

            if (age!= 19)
            {
                // "Not equal to"
                // ! bang operator
            }
        }

        [TestMethod]                                //testm tab tab
        public void SwitchCases()                   //Do something in this case, do something else in other cases
        {
            int age = 42;

            switch (age)
            {
                case 18:
                    // Code for if age = 18
                    break;                          // Breaks us out of the case once something is true
                case 19:
                    // Code for if age = 19
                    break;
                case 20:
                    // Code for if age = 20
                    break;
                case 21:                            //Stacking cases
                case 22:
                case 23:
                    //Code for ages 21-23
                    break;
                default:
                    // Catch all code
                    Console.WriteLine("You're not 18-23");
                    break;
            }
        }

        [TestMethod]
        public void Ternaries()
        {
            int age = 47;

            //bool someVariable = (boolean statement) ? trueValue : falseValue;

            bool isAge = (age == 24) ? true : false;        //Would return false
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods2
{
    [TestClass]
    public class Method2Examples
    {
        //Input
        //What we do
        //Output

        // void = Method isn't going to return any value
        //4 parts of methods-                                                                   
        //Access Modifier (public), Return Type or output (void), Method Signature = name and parameters(), body is in {}

        public int AddTwoBankAccounts(int chkAcct, int savAcct)
        {
            int sum = chkAcct + savAcct;
            return sum;
        }

        private int SubtractTwoNumbers(int creditLimit, int shopExp)
        {
            int availCredit = creditLimit - shopExp;
            return availCredit;
        }

        private int GrowYield(int plants, int flowers)
        {
            int yield = plants * flowers;
            return yield;
        }

        private int DivideYield(int lbsOfProduct, int numOfCustomers)
        {
            int avgSales = lbsOfProduct / numOfCustomers;
            return avgSales;
        }

        private int TaxCredit(int totalSales, int taxRate)
        {
            int taxCredit = totalSales % taxRate;
            return taxCredit;
        }


        [TestMethod]
        public void MethodTest()
        {
            int myBalance = AddTwoBankAccounts(700, 900);      //arguments
            Assert.AreEqual(1600, myBalance);


        }
    }
}

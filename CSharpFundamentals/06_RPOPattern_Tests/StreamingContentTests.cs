using System;
using _06_REPOPattern_REPO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_RPOPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            // Arrange
            StreamingContent content = new StreamingContent();
            content.Title = "Toy Story";                                    //Properties

            // Act
            //Declare 2 variable
            string expected = "Toy Story";
            string actual = content.Title;

            // Assert
            Assert.AreEqual(expected, actual);  //THese don't have to match the 2 variables
        }
    }
}

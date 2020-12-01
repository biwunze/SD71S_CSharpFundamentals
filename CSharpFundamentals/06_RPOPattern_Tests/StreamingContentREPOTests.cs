using _06_REPOPattern_REPO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_RPOPattern_Tests
{
    [TestClass]
    public class StreamingContentREPOTests
    {
        private StreamingContentRepository _repo;
        private StreamingContent _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode and goes on a murderous rampage through the Californian desert.", "R", 5.8, false, GenreType.Drama);

            _repo.AddContentToList(_content);
        }



        // Add Method - When you do this, this is what happens
        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {
            // Arrange = Setting up the playing field.  
            StreamingContent content = new StreamingContent();
            content.Title = "Friday";
            StreamingContentRepository repository = new StreamingContentRepository();
            
            // Act = Get/run the code we want to test.
            repository.AddContentToList(content);
            StreamingContent contentFromDirectory = repository.GetContentByTitle("Friday");

            // Assert = Use the Assert class to verify the expected outcome.
            Assert.IsNotNull(contentFromDirectory);
        }

        // Update = Create streaming content object, create repo, add to repo, update the object, verify update worked, then assert.
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            // Arrange
            // TestInitialize
            StreamingContent newContent = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode and goes on a murderous rampage through the Californian desert.", "R", 10, false, GenreType.Action);

            // Act
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);

            // Assert
            Assert.IsTrue(updateResult);
        }

        [DataTestMethod]
        [DataRow("Rubber", true)]
        [DataRow("Toy Story", false)]
        public void UpdateExistingContent_ShouldMatchGivenBool(string originalTitle, bool shouldUpdate)
        {
            // Arrange
            // TestInitialize
            StreamingContent newContent = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode and goes on a murderous rampage through the Californian desert.", "R", 10, false, GenreType.Action);

            // Act
            bool updateResult = _repo.UpdateExistingContent(originalTitle, newContent);

            // Assert
            Assert.AreEqual(shouldUpdate, updateResult);
        }

        [TestMethod]
        public void DeleteContent_ShouldReturnTrue()
        {
            // Arrange

            // Act
            bool deleteResult = _repo.RemoveContentFromList(_content.Title);

            // Assert
            Assert.IsTrue(deleteResult);

        }

    }
}

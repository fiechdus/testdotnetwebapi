using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WebApplication1;

namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        private ToDoController _controller;
        
        [TestInitialize]
        public void Initialize()
        {
            _controller = new ToDoController();
        }
        
        [TestMethod]
        public void TestMethodApiToDo()
        {
            // Arrange
            var expected = new List<ToDo>();

            // Act
            var result = _controller.getToDos(); // or .GetToDos()
            
            // If the controller returns Ok(...) or similar, you can unwrap the Value.
            var okResult = result.Result as OkObjectResult;
            Assert.IsNotNull(okResult, "Expected an OkObjectResult.");

            var actual = okResult.Value as List<ToDo>;
            Assert.IsNotNull(actual, "Expected a List<ToDo> as the value.");

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
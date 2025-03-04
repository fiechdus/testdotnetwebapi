using WebApplication1;

namespace TestProject1;

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
    public void TestMethod1()
    {
        Assert.AreEqual(true, true);
    }
    
    [TestMethod]
    public void TestMethodApiToDo()
    {
        // TODO: Fix this error
        Assert.AreEqual(_controller.getToDos(), new List<ToDo>());
    }
}